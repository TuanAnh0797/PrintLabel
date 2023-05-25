namespace Print_label
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_sn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ipserver = new System.Windows.Forms.TextBox();
            this.btn_inlai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_snpre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_start.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_start.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(77, 142);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(201, 47);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Kết nối";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_sn
            // 
            this.txt_sn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sn.Location = new System.Drawing.Point(72, 63);
            this.txt_sn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(208, 23);
            this.txt_sn.TabIndex = 1;
            this.txt_sn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "SN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Server";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ipserver);
            this.panel1.Controls.Add(this.btn_inlai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_snpre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_sn);
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 201);
            this.panel1.TabIndex = 5;
            // 
            // txt_ipserver
            // 
            this.txt_ipserver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ipserver.Location = new System.Drawing.Point(120, 101);
            this.txt_ipserver.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ipserver.Name = "txt_ipserver";
            this.txt_ipserver.ReadOnly = true;
            this.txt_ipserver.Size = new System.Drawing.Size(160, 23);
            this.txt_ipserver.TabIndex = 1;
            // 
            // btn_inlai
            // 
            this.btn_inlai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inlai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_inlai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inlai.Location = new System.Drawing.Point(288, 53);
            this.btn_inlai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inlai.Name = "btn_inlai";
            this.btn_inlai.Size = new System.Drawing.Size(65, 47);
            this.btn_inlai.TabIndex = 6;
            this.btn_inlai.Text = "In lại";
            this.btn_inlai.UseVisualStyleBackColor = false;
            this.btn_inlai.Click += new System.EventHandler(this.btn_inlai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "SNpre";
            // 
            // txt_snpre
            // 
            this.txt_snpre.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_snpre.Location = new System.Drawing.Point(72, 20);
            this.txt_snpre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_snpre.Name = "txt_snpre";
            this.txt_snpre.ReadOnly = true;
            this.txt_snpre.ShortcutsEnabled = false;
            this.txt_snpre.Size = new System.Drawing.Size(208, 23);
            this.txt_snpre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 68);
            this.label3.TabIndex = 3;
            this.label3.Text = "TAMRON";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer Label";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sn;
        private System.Windows.Forms.Button btn_inlai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_snpre;
        private System.Windows.Forms.TextBox txt_ipserver;
        private System.Windows.Forms.Label label3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

