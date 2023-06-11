namespace E_ugostiteljstvo
{
    partial class MainForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.btnCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(670, 222);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(62, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(657, 276);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(87, 24);
            this.btnRegistracija.TabIndex = 3;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "e-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "lozinka:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(627, 188);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(148, 20);
            this.txtLozinka.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(627, 150);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ili";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(154, 417);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(83, 29);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Prijava";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pcbUser
            // 
            this.pcbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbUser.Location = new System.Drawing.Point(20, 132);
            this.pcbUser.Margin = new System.Windows.Forms.Padding(2);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(360, 252);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUser.TabIndex = 0;
            this.pcbUser.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prijava";
            // 
            // cboDevices
            // 
            this.cboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(20, 87);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(236, 21);
            this.cboDevices.TabIndex = 10;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(262, 87);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(118, 23);
            this.btnCapture.TabIndex = 11;
            this.btnCapture.Text = "Uključi kameru";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 473);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.pcbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.Button btnCapture;
    }
}

