namespace E_ugostiteljstvo
{
    partial class FrmDodajNamirnicuUKatalog
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtRokUporabe = new System.Windows.Forms.TextBox();
            this.txtOptZalihe = new System.Windows.Forms.TextBox();
            this.txtMinZalihe = new System.Windows.Forms.TextBox();
            this.cmbMjJed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pcbQR = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVrstanNamirnice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(433, 92);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(135, 22);
            this.txtNaziv.TabIndex = 0;
            // 
            // txtRokUporabe
            // 
            this.txtRokUporabe.Location = new System.Drawing.Point(604, 201);
            this.txtRokUporabe.Name = "txtRokUporabe";
            this.txtRokUporabe.Size = new System.Drawing.Size(135, 22);
            this.txtRokUporabe.TabIndex = 1;
            // 
            // txtOptZalihe
            // 
            this.txtOptZalihe.Location = new System.Drawing.Point(604, 92);
            this.txtOptZalihe.Name = "txtOptZalihe";
            this.txtOptZalihe.Size = new System.Drawing.Size(135, 22);
            this.txtOptZalihe.TabIndex = 2;
            // 
            // txtMinZalihe
            // 
            this.txtMinZalihe.Location = new System.Drawing.Point(433, 255);
            this.txtMinZalihe.Name = "txtMinZalihe";
            this.txtMinZalihe.Size = new System.Drawing.Size(135, 22);
            this.txtMinZalihe.TabIndex = 3;
            // 
            // cmbMjJed
            // 
            this.cmbMjJed.FormattingEnabled = true;
            this.cmbMjJed.Items.AddRange(new object[] {
            "kom",
            "kg",
            "g",
            "ml",
            "l"});
            this.cmbMjJed.Location = new System.Drawing.Point(604, 145);
            this.cmbMjJed.Name = "cmbMjJed";
            this.cmbMjJed.Size = new System.Drawing.Size(135, 24);
            this.cmbMjJed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mjerna jedinica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Optimalne zalihe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimalne zalihe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrsta Namirnice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rok uporabe u danima:";
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(174, 357);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(110, 47);
            this.btnGenerateQR.TabIndex = 13;
            this.btnGenerateQR.Text = "Generiraj QR kod";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 47);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(527, 357);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 47);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pcbQR
            // 
            this.pcbQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbQR.Location = new System.Drawing.Point(79, 73);
            this.pcbQR.Name = "pcbQR";
            this.pcbQR.Size = new System.Drawing.Size(275, 250);
            this.pcbQR.TabIndex = 16;
            this.pcbQR.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "QR kod:";
            // 
            // cmbVrstanNamirnice
            // 
            this.cmbVrstanNamirnice.FormattingEnabled = true;
            this.cmbVrstanNamirnice.Items.AddRange(new object[] {
            "Mliječni",
            "Meso",
            "Riba",
            "Povrće",
            "Voće",
            "Prerađeni proizvodi",
            "Pekarski proizvodi",
            "Slastice",
            "Tjestenine",
            "Začini",
            "Životinjski proizvodi"});
            this.cmbVrstanNamirnice.Location = new System.Drawing.Point(433, 149);
            this.cmbVrstanNamirnice.Name = "cmbVrstanNamirnice";
            this.cmbVrstanNamirnice.Size = new System.Drawing.Size(135, 24);
            this.cmbVrstanNamirnice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(433, 204);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(135, 22);
            this.txtCijena.TabIndex = 20;
            // 
            // FrmDodajNamirnicuUKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 435);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbVrstanNamirnice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcbQR);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMjJed);
            this.Controls.Add(this.txtMinZalihe);
            this.Controls.Add(this.txtOptZalihe);
            this.Controls.Add(this.txtRokUporabe);
            this.Controls.Add(this.txtNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDodajNamirnicuUKatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Namirnicu U Katalog";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajNamirnicuUKatalog_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pcbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtRokUporabe;
        private System.Windows.Forms.TextBox txtOptZalihe;
        private System.Windows.Forms.TextBox txtMinZalihe;
        private System.Windows.Forms.ComboBox cmbMjJed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pcbQR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVrstanNamirnice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCijena;
    }
}