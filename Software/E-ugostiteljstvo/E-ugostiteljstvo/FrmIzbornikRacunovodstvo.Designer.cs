namespace E_ugostiteljstvo
{
    partial class FrmIzbornikRacunovodstvo
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
            this.btnPregledNarudzbenica = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregledNarudzbenica
            // 
            this.btnPregledNarudzbenica.Location = new System.Drawing.Point(106, 89);
            this.btnPregledNarudzbenica.Name = "btnPregledNarudzbenica";
            this.btnPregledNarudzbenica.Size = new System.Drawing.Size(140, 81);
            this.btnPregledNarudzbenica.TabIndex = 0;
            this.btnPregledNarudzbenica.Text = "Pregled narudžbenica";
            this.btnPregledNarudzbenica.UseVisualStyleBackColor = true;
            this.btnPregledNarudzbenica.Click += new System.EventHandler(this.btnPregledNarudzbenica_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ističe rok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "Statistika potrošnje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(237, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Odjava";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmIzbornikRacunovodstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 455);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPregledNarudzbenica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmIzbornikRacunovodstvo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Računovodstvo";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmIzbornikRacunovodstvo_HelpRequested);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregledNarudzbenica;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
    }
}