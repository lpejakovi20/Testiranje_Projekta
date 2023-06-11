namespace E_ugostiteljstvo
{
    partial class FrmRegistracija
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
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.btnSlikaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.btnUkljuci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pcbSlika2 = new System.Windows.Forms.PictureBox();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSlika
            // 
            this.pcbSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbSlika.Location = new System.Drawing.Point(19, 130);
            this.pcbSlika.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(469, 302);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSlika.TabIndex = 0;
            this.pcbSlika.TabStop = false;
            // 
            // btnSlikaj
            // 
            this.btnSlikaj.Location = new System.Drawing.Point(414, 451);
            this.btnSlikaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlikaj.Name = "btnSlikaj";
            this.btnSlikaj.Size = new System.Drawing.Size(74, 40);
            this.btnSlikaj.TabIndex = 1;
            this.btnSlikaj.Text = "Slikaj";
            this.btnSlikaj.UseVisualStyleBackColor = true;
            this.btnSlikaj.Click += new System.EventHandler(this.btnSlikaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Radno mjesto";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(684, 280);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(684, 304);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(141, 20);
            this.txtLozinka.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(684, 330);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(141, 20);
            this.txtIme.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(684, 358);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(141, 20);
            this.txtPrezime.TabIndex = 11;
            // 
            // cmbRadnoMjesto
            // 
            this.cmbRadnoMjesto.FormattingEnabled = true;
            this.cmbRadnoMjesto.Location = new System.Drawing.Point(711, 392);
            this.cmbRadnoMjesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRadnoMjesto.Name = "cmbRadnoMjesto";
            this.cmbRadnoMjesto.Size = new System.Drawing.Size(114, 21);
            this.cmbRadnoMjesto.TabIndex = 12;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(696, 439);
            this.btnRegistriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(76, 26);
            this.btnRegistriraj.TabIndex = 13;
            this.btnRegistriraj.Text = "Registriraj se";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // btnUkljuci
            // 
            this.btnUkljuci.Location = new System.Drawing.Point(387, 100);
            this.btnUkljuci.Margin = new System.Windows.Forms.Padding(2);
            this.btnUkljuci.Name = "btnUkljuci";
            this.btnUkljuci.Size = new System.Drawing.Size(101, 26);
            this.btnUkljuci.TabIndex = 14;
            this.btnUkljuci.Text = "Uključi kameru";
            this.btnUkljuci.UseVisualStyleBackColor = true;
            this.btnUkljuci.Click += new System.EventHandler(this.btnUkljuci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Registracija";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 28);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pcbSlika2
            // 
            this.pcbSlika2.Location = new System.Drawing.Point(590, 34);
            this.pcbSlika2.Name = "pcbSlika2";
            this.pcbSlika2.Size = new System.Drawing.Size(260, 215);
            this.pcbSlika2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSlika2.TabIndex = 17;
            this.pcbSlika2.TabStop = false;
            // 
            // cboDevices
            // 
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(19, 100);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(363, 21);
            this.cboDevices.TabIndex = 18;
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 510);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.pcbSlika2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUkljuci);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.cmbRadnoMjesto);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSlikaj);
            this.Controls.Add(this.pcbSlika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.FrmRegistracija_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRegistracija_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.Button btnSlikaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbRadnoMjesto;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.Button btnUkljuci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pcbSlika2;
        private System.Windows.Forms.ComboBox cboDevices;
    }
}