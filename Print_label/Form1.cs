using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Print_label
{
    public partial class Form1 : Form
    {
        Thread thr;
        ThreadStart ths;
        TcpClient tcpclientrv;
        TcpListener MyServer;
        IPAddress ipaddress_server;
        TcpClient Myclient = new TcpClient();
        NetworkStream MyNetworkStream;
        bool checkconvertipserver;
        bool checkstatus = false;
        bool recivedataclient;
        string pathfileconfig;
        string contentfileconfig;
        Config myconfig;
        string sndisplay;
        public Form1()
        {
            checkconvertipserver = false;
            pathfileconfig = Directory.GetCurrentDirectory();
            contentfileconfig = File.ReadAllText(pathfileconfig+"\\config.json");
            InitializeComponent();
            locationscreen();
            myconfig = JsonConvert.DeserializeObject<Config>(contentfileconfig);
            txt_ipserver.Text = myconfig.IpAddress_server;
            checkconvertipserver = IPAddress.TryParse(myconfig.IpAddress_server, out ipaddress_server);
            if (checkconvertipserver == false)
            {
                MessageBox.Show("Sai định dạng Ipaddress");
            }
            fileSystemWatcher1.Path = myconfig.Logpath1;
            fileSystemWatcher1.IncludeSubdirectories = true;
            fileSystemWatcher1.Filter = "*.log";
            fileSystemWatcher1.EnableRaisingEvents = true;
        }
        public void locationscreen()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int sizehei = this.Size.Height;
            int sizewit = this.Size.Width;
            Point p = new Point(screenWidth-sizewit, screenHeight-sizehei-40);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = p;
        }
        public void PrintLabel(string sn1)
        {
            bool flag = File.Exists("temp.prn");
            if (flag)
            {
                File.Delete("temp.prn");
            }
            File.Copy("print.prn", "temp.prn");
            Thread.Sleep(100);
            if(sn1.Length == 16)
            {
                    // tem1
                    string text = File.ReadAllText("temp.prn");
                    text = text.Replace("ABCDEFGHIJKLMNOP", sn1);
                    text = text.Replace("ABCDEF", sn1.Substring(0, 6));
                    text = text.Replace("GHIJKL", sn1.Substring(6, 6));
                    text = text.Replace("MNOP", sn1.Substring(12, 4));
                    // tem2
                    text = text.Replace("PONMLKJIHGFEDCBA", sn1);
                    text = text.Replace("PONMLK", sn1.Substring(0, 6));
                    text = text.Replace("JIHGFE", sn1.Substring(6, 6));
                    text = text.Replace("DCBA", sn1.Substring(12, 4));

                    File.WriteAllText("temp.prn", text);
                    string filename = "print.bat";
                    string parameters = "/c" + filename;
                    Process cmdProcess = Process.Start("cmd", parameters);
                    sndisplay = sn1;
                    txt_sn?.Invoke(new Action(txtshow));
            }
           
        }
        //
        public void PrintLabelclient(string sn1)
        {
            bool flag = File.Exists("temp.prn");
            if (flag)
            {
                File.Delete("temp.prn");
            }
            File.Copy("print.prn", "temp.prn");
            Thread.Sleep(100);
            if (sn1.Length == 16)
            {
                // tem1
                string text = File.ReadAllText("temp.prn");
                text = text.Replace("ABCDEFGHIJKLMNOP", sn1);
                text = text.Replace("ABCDEF", sn1.Substring(0, 6));
                text = text.Replace("GHIJKL", sn1.Substring(6, 6));
         
                text = text.Replace("MNOP", sn1.Substring(12, 4));
                // tem2
                text = text.Replace("PONMLKJIHGFEDCBA", sn1);
                text = text.Replace("PONMLK", sn1.Substring(0, 6));
                text = text.Replace("JIHGFE", sn1.Substring(6, 6));
                text = text.Replace("DCBA", sn1.Substring(12, 4));

                File.WriteAllText("temp.prn", text);
                string filename = "print.bat";
                string parameters = "/c" + filename;
                Process cmdProcess = Process.Start("cmd", parameters);
                //sndisplay = sn1;
                //txt_sn?.Invoke(new Action(txtshow));
            }

        }
        //
        public void txtshow()
        {
            txt_snpre.Text = sndisplay;
            txt_sn.Text = "";
        }
           public void recivedatafromclient()
        {
            byte[] datarecive = new byte[40];
            string datatoprint;
            Array.Clear(datarecive,0, datarecive.Length);
            datatoprint = null;
            while (recivedataclient)
            {
                try
                {
                    tcpclientrv = MyServer.AcceptTcpClient();
                    MyNetworkStream = tcpclientrv.GetStream();
                    MyNetworkStream.Read(datarecive, 0, datarecive.Length);
                    datatoprint = Encoding.ASCII.GetString(datarecive).Trim('\0');
                    PrintLabelclient(datatoprint);
                    Array.Clear(datarecive, 0, datarecive.Length);
                    datatoprint = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã đóng Server");
                }

            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            //ths = new ThreadStart(recivedatafromclient);
            //thr = new Thread(ths);
            Task taskrecivedata;
            if (!checkstatus & checkconvertipserver & myconfig.ClientorServer == "Server")
            {
                MyServer = new TcpListener(ipaddress_server, 6000);
                MyServer.Start();
                recivedataclient = true;
                taskrecivedata = new TaskFactory().StartNew(new Action(recivedatafromclient));
                //thr.Start();
                btn_start.Text = "Ngắt kết nối";
                btn_start.BackColor = Color.Red;
                checkstatus= true;
               
            }
            else if (!checkstatus & checkconvertipserver & myconfig.ClientorServer == "Client")
            {
                
                btn_start.Text = "Ngắt kết nối";
                btn_start.BackColor = Color.Red;
                checkstatus = true;

            }
            else if(checkstatus)
            {
                    recivedataclient = false;
                    btn_start.Text = "Kết Nối";
                    btn_start.BackColor = Color.SeaGreen;
                //thr.Abort();
                if(MyServer != null)
                {
                    MyServer.Stop();
                }
                 checkstatus = false;
            }
        }
        private void btn_inlai_Click(object sender, EventArgs e)
        {
            if(myconfig.ClientorServer == "Server")
            {
                PrintLabel(txt_sn.Text.Trim());
            }
            if(myconfig.ClientorServer == "Client")
            {
                sendatatoserver(txt_sn.Text);
            }
            
        }
        public void sendatatoserver(string datasendtoserver)
        {
            byte[] buff = Encoding.UTF8.GetBytes(datasendtoserver);
            Myclient = new TcpClient();
            Myclient.Connect(myconfig.IpAddress_server, 6000);
            MyNetworkStream = Myclient.GetStream();
            MyNetworkStream.Write(buff, 0, buff.Length);
            Array.Clear(buff,0, buff.Length);
            txt_snpre.Text = txt_sn.Text;
            txt_sn.Text = null;
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string nameFile = e.Name;
            string sn = nameFile.Split('_')[1];
            if (myconfig.ClientorServer == "Client")
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn in tem không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
                if (dialog == DialogResult.Yes)
                {
                    sendatatoserver(sn);
                }
            }
            if (myconfig.ClientorServer == "Server")
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn in tem không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
               
                if (dialog == DialogResult.Yes)
                {
                    PrintLabel(sn);
                }
            }
        }
       
        private void txt_sn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
