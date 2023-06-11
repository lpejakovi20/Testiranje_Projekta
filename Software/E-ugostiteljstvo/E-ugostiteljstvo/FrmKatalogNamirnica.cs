using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_ugostiteljstvo
{
    ///<author>Nikola Parag</author>
    public partial class FrmKatalogNamirnica : Form
    {
        private KatalogNamirnicaServices services = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
        private NamirnicaServices servicesNamirnica = new NamirnicaServices(new NamirnicaRepository());  
        public FrmKatalogNamirnica()
        {
            InitializeComponent();
            this.HelpRequested += FrmKatalogNamirnica_HelpRequested;
        }

        private void FrmKatalogNamirnica_Load(object sender, EventArgs e)
        {
            ShowKatalogNamirnica();
        }

        private void ShowKatalogNamirnica()
        {
            var katalogNamirnica = services.GetKatalogNamirnica();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;
            dgvKatalogNamirnica.Columns[7].Visible = false;
            dgvKatalogNamirnica.Columns[9].Visible = false;
            dgvKatalogNamirnica.Columns[10].Visible = false;
            dgvKatalogNamirnica.Columns[11].Visible = false;
            dgvKatalogNamirnica.Columns[12].Visible = false;

            cmbFilters.SelectedIndex = -1;
            cmbSort.SelectedIndex = -1;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phrase = txtSearch.Text;
            var katalogNamirnica = services.GetKatalogNamirnicaByName(phrase);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = katalogNamirnica;
            dgvKatalogNamirnica.DataSource = bindingSource;


         
        }

        private void ShowFiltered(string selecteditem)
        {
            var katalogNamirnica = services.GetFiltered(selecteditem);
            dgvKatalogNamirnica.DataSource = katalogNamirnica;
        }

        private void btnObrisiPrikaz_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ShowKatalogNamirnica();
        }

        private void Sort(int selectedIndex)
        {
            List<namirnica_u_katalogu> katalogNamirnica;
            switch (selectedIndex)
            {
                case 0:
                    katalogNamirnica = services.SortKraciRok();
                    break;
                case 1:
                    katalogNamirnica = services.SortDuziRok();
                    break;
                case 2:
                    katalogNamirnica = services.SortManjaCijena();
                    break;
                case 3:
                    katalogNamirnica = services.SortVecaCijena();
                    break;
                default:
                    return;
            }
            dgvKatalogNamirnica.DataSource = new BindingSource { DataSource = katalogNamirnica };
        }

        private void btnCreateNarudzbenica_Click(object sender, EventArgs e)
        {
            var frmNarudzbenica = new FrmKreirajNarudžbenicu();
            Hide();
            frmNarudzbenica.ShowDialog();
            Close();
        }

        private void btnAddNewNamirnica_Click(object sender, EventArgs e)
        {
            var form = new FrmDodajNamirnicuUKatalog();
            form.ShowDialog();
        }

        private void btnCreateIzdatnica_Click(object sender, EventArgs e)
        {
            FrmStavkeIzdatnice form = new FrmStavkeIzdatnice();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new MainForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void cmbSort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Sort(cmbSort.SelectedIndex);
        }

        private void cmbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cmbFilters.SelectedIndex >= 0)
            {
                string selectedItem = cmbFilters.SelectedItem.ToString();
                ShowFiltered(selectedItem);                
            }
        }

        private void dgvKatalogNamirnica_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvKatalogNamirnica.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                var selectedNamirnica = dgvKatalogNamirnica.CurrentRow.DataBoundItem as namirnica_u_katalogu;
                var namirniceSkladiste = servicesNamirnica.GetNamirniceUSkladistu(selectedNamirnica.id);
                dgvNamirniceUSkladistu.DataSource = namirniceSkladiste;
                dgvNamirniceUSkladistu.Columns[3].Visible = false;
                dgvNamirniceUSkladistu.Columns[4].Visible = false;
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvKatalogNamirnica.CurrentRow.Index;
            if (selectedRowIndex >= 0)
            {
                var selectedNamirnica = dgvKatalogNamirnica.CurrentRow.DataBoundItem as namirnica_u_katalogu;
                var namirniceSkladiste = servicesNamirnica.GetNamirniceUSkladistu(selectedNamirnica.id);
                if (selectedNamirnica != null) { 
                    if(namirniceSkladiste.Count == 0) { 
                        var IsDeleted = services.DeleteNamirnica(selectedNamirnica);
                        if (IsDeleted)
                        {
                            MessageBox.Show("Izbrisana namirnica!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("INamirnica nije izbrisana! Ima postojeće namirnice u skladištu!");
                    }
                }
                ShowKatalogNamirnica();
            }
        }

        private void FrmKatalogNamirnica_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "KatalogNamirnica");
        }


    }
}
