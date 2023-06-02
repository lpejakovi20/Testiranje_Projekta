namespace E_ugostiteljstvo
{
    partial class FrmStavkeNarudzbenice
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.lblSveukupanIznos = new System.Windows.Forms.Label();
            this.btnIzradiPrimku = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stavke narudžbenice:";
            // 
            // dgvStavkeNarudzbenice
            // 
            this.dgvStavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbenice.Location = new System.Drawing.Point(44, 96);
            this.dgvStavkeNarudzbenice.Name = "dgvStavkeNarudzbenice";
            this.dgvStavkeNarudzbenice.RowHeadersWidth = 51;
            this.dgvStavkeNarudzbenice.RowTemplate.Height = 24;
            this.dgvStavkeNarudzbenice.Size = new System.Drawing.Size(724, 256);
            this.dgvStavkeNarudzbenice.TabIndex = 1;
            // 
            // lblSveukupanIznos
            // 
            this.lblSveukupanIznos.AutoSize = true;
            this.lblSveukupanIznos.Location = new System.Drawing.Point(44, 384);
            this.lblSveukupanIznos.Name = "lblSveukupanIznos";
            this.lblSveukupanIznos.Size = new System.Drawing.Size(112, 16);
            this.lblSveukupanIznos.TabIndex = 2;
            this.lblSveukupanIznos.Text = "Sveukupan iznos:";
            // 
            // btnIzradiPrimku
            // 
            this.btnIzradiPrimku.Location = new System.Drawing.Point(667, 375);
            this.btnIzradiPrimku.Name = "btnIzradiPrimku";
            this.btnIzradiPrimku.Size = new System.Drawing.Size(101, 35);
            this.btnIzradiPrimku.TabIndex = 5;
            this.btnIzradiPrimku.Text = "Izradi Primku";
            this.btnIzradiPrimku.UseVisualStyleBackColor = true;
            this.btnIzradiPrimku.Click += new System.EventHandler(this.btnIzradiPrimku_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(162, 384);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(14, 16);
            this.lblIznos.TabIndex = 6;
            this.lblIznos.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 34);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmStavkeNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.btnIzradiPrimku);
            this.Controls.Add(this.lblSveukupanIznos);
            this.Controls.Add(this.dgvStavkeNarudzbenice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStavkeNarudzbenice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke Narudžbenice";
            this.Load += new System.EventHandler(this.FrmStavkeNarudzbenice_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmStavkeNarudzbenice_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbenice;
        private System.Windows.Forms.Label lblSveukupanIznos;
        private System.Windows.Forms.Button btnIzradiPrimku;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Button btnBack;
    }
}