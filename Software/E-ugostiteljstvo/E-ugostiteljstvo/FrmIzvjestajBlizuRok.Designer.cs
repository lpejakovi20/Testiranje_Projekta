namespace E_ugostiteljstvo
{
    partial class FrmIzvjestajBlizuRok
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.namirnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerRok = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stavkaIzvjestajaBlizuRokaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.namirnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaIzvjestajaBlizuRokaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // namirnicaBindingSource
            // 
            this.namirnicaBindingSource.DataSource = typeof(EntitiesLayer.Entities.namirnica);
            // 
            // reportViewerRok
            // 
            this.reportViewerRok.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSNamirnice";
            reportDataSource1.Value = this.namirnicaBindingSource;
            reportDataSource2.Name = "DSStavkeBlizuRoka";
            reportDataSource2.Value = this.stavkaIzvjestajaBlizuRokaBindingSource;
            this.reportViewerRok.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRok.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRok.LocalReport.ReportEmbeddedResource = "E_ugostiteljstvo.IzvjestajBlizuRok.rdlc";
            this.reportViewerRok.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRok.Name = "reportViewerRok";
            this.reportViewerRok.ServerReport.BearerToken = null;
            this.reportViewerRok.Size = new System.Drawing.Size(800, 450);
            this.reportViewerRok.TabIndex = 0;
            // 
            // stavkaIzvjestajaBlizuRokaBindingSource
            // 
            this.stavkaIzvjestajaBlizuRokaBindingSource.DataSource = typeof(EntitiesLayer.StavkaIzvjestajaBlizuRoka);
            // 
            // FrmIzvjestajBlizuRok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerRok);
            this.Name = "FrmIzvjestajBlizuRok";
            this.Text = "FrmIzvjestajBlizuRok";
            this.Load += new System.EventHandler(this.FrmIzvjestajBlizuRok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.namirnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaIzvjestajaBlizuRokaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRok;
        private System.Windows.Forms.BindingSource namirnicaBindingSource;
        private System.Windows.Forms.BindingSource stavkaIzvjestajaBlizuRokaBindingSource;
    }
}