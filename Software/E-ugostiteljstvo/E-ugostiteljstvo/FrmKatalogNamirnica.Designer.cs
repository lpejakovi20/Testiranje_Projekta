namespace E_ugostiteljstvo
{
    partial class FrmKatalogNamirnica
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.dgvKatalogNamirnica = new System.Windows.Forms.DataGridView();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnAddNewNamirnica = new System.Windows.Forms.Button();
            this.btnCreateNarudzbenica = new System.Windows.Forms.Button();
            this.dgvNamirniceUSkladistu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrisiPrikaz = new System.Windows.Forms.Button();
            this.btnCreateIzdatnica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalogNamirnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirniceUSkladistu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1117, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 41);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Odjava";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(394, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Katalog Namirnica:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(209, 95);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // cmbFilters
            // 
            this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Items.AddRange(new object[] {
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
            this.cmbFilters.Location = new System.Drawing.Point(576, 91);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(152, 24);
            this.cmbFilters.TabIndex = 4;
            this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
            // 
            // dgvKatalogNamirnica
            // 
            this.dgvKatalogNamirnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKatalogNamirnica.Location = new System.Drawing.Point(42, 136);
            this.dgvKatalogNamirnica.Name = "dgvKatalogNamirnica";
            this.dgvKatalogNamirnica.ReadOnly = true;
            this.dgvKatalogNamirnica.RowHeadersWidth = 51;
            this.dgvKatalogNamirnica.RowTemplate.Height = 24;
            this.dgvKatalogNamirnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKatalogNamirnica.Size = new System.Drawing.Size(1147, 225);
            this.dgvKatalogNamirnica.TabIndex = 5;
            this.dgvKatalogNamirnica.SelectionChanged += new System.EventHandler(this.dgvKatalogNamirnica_SelectionChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Sortiraj po najkraćem roku",
            "Sortiraj po najdužem roku",
            "Sortiraj po najmanjoj cijeni",
            "Sortiraj po najvećoj cijeni"});
            this.cmbSort.Location = new System.Drawing.Point(821, 91);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(209, 24);
            this.cmbSort.TabIndex = 6;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged_1);
            // 
            // btnAddNewNamirnica
            // 
            this.btnAddNewNamirnica.Location = new System.Drawing.Point(923, 394);
            this.btnAddNewNamirnica.Name = "btnAddNewNamirnica";
            this.btnAddNewNamirnica.Size = new System.Drawing.Size(130, 44);
            this.btnAddNewNamirnica.TabIndex = 8;
            this.btnAddNewNamirnica.Text = "Dodaj novu namirnicu";
            this.btnAddNewNamirnica.UseVisualStyleBackColor = true;
            this.btnAddNewNamirnica.Click += new System.EventHandler(this.btnAddNewNamirnica_Click);
            // 
            // btnCreateNarudzbenica
            // 
            this.btnCreateNarudzbenica.Location = new System.Drawing.Point(1059, 645);
            this.btnCreateNarudzbenica.Name = "btnCreateNarudzbenica";
            this.btnCreateNarudzbenica.Size = new System.Drawing.Size(130, 44);
            this.btnCreateNarudzbenica.TabIndex = 9;
            this.btnCreateNarudzbenica.Text = "Kreiraj narudžbenicu";
            this.btnCreateNarudzbenica.UseVisualStyleBackColor = true;
            this.btnCreateNarudzbenica.Click += new System.EventHandler(this.btnCreateNarudzbenica_Click);
            // 
            // dgvNamirniceUSkladistu
            // 
            this.dgvNamirniceUSkladistu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirniceUSkladistu.Location = new System.Drawing.Point(42, 454);
            this.dgvNamirniceUSkladistu.Name = "dgvNamirniceUSkladistu";
            this.dgvNamirniceUSkladistu.ReadOnly = true;
            this.dgvNamirniceUSkladistu.RowHeadersWidth = 51;
            this.dgvNamirniceUSkladistu.RowTemplate.Height = 24;
            this.dgvNamirniceUSkladistu.Size = new System.Drawing.Size(497, 235);
            this.dgvNamirniceUSkladistu.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filteri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sortiranja:";
            // 
            // btnObrisiPrikaz
            // 
            this.btnObrisiPrikaz.Location = new System.Drawing.Point(1059, 87);
            this.btnObrisiPrikaz.Name = "btnObrisiPrikaz";
            this.btnObrisiPrikaz.Size = new System.Drawing.Size(130, 30);
            this.btnObrisiPrikaz.TabIndex = 14;
            this.btnObrisiPrikaz.Text = "Resetiraj prikaz";
            this.btnObrisiPrikaz.UseVisualStyleBackColor = true;
            this.btnObrisiPrikaz.Click += new System.EventHandler(this.btnObrisiPrikaz_Click);
            // 
            // btnCreateIzdatnica
            // 
            this.btnCreateIzdatnica.Location = new System.Drawing.Point(876, 645);
            this.btnCreateIzdatnica.Name = "btnCreateIzdatnica";
            this.btnCreateIzdatnica.Size = new System.Drawing.Size(130, 44);
            this.btnCreateIzdatnica.TabIndex = 15;
            this.btnCreateIzdatnica.Text = "Kreiraj izdatnicu";
            this.btnCreateIzdatnica.UseVisualStyleBackColor = true;
            this.btnCreateIzdatnica.Click += new System.EventHandler(this.btnCreateIzdatnica_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Namirnice u skladištu:";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(1059, 394);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(130, 44);
            this.btnIzbrisi.TabIndex = 17;
            this.btnIzbrisi.Text = "Izbriši namirnicu";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // FrmKatalogNamirnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 741);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateIzdatnica);
            this.Controls.Add(this.btnObrisiPrikaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNamirniceUSkladistu);
            this.Controls.Add(this.btnCreateNarudzbenica);
            this.Controls.Add(this.btnAddNewNamirnica);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.dgvKatalogNamirnica);
            this.Controls.Add(this.cmbFilters);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKatalogNamirnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katalog Namirnica";
            this.Load += new System.EventHandler(this.FrmKatalogNamirnica_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmKatalogNamirnica_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalogNamirnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirniceUSkladistu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.DataGridView dgvKatalogNamirnica;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnAddNewNamirnica;
        private System.Windows.Forms.Button btnCreateNarudzbenica;
        private System.Windows.Forms.DataGridView dgvNamirniceUSkladistu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisiPrikaz;
        private System.Windows.Forms.Button btnCreateIzdatnica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}