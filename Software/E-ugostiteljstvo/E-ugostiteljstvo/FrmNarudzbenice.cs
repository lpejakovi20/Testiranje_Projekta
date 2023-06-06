using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class FrmNarudzbenice : Form
    {

        public FrmNarudzbenice()
        {
            InitializeComponent();
        }

        NarudzbenicaServices servisNarudzbenice = new NarudzbenicaServices(new NarudzbenicaRepository());

        private void FrmNarudzbenice_Load(object sender, EventArgs e)
        {
            PrikaziNarudzbenice();
            this.HelpRequested += FrmNarudzbenice_HelpRequested;

        }

        private void PrikaziNarudzbenice()
        {
            var narudzbenice = servisNarudzbenice.GetNarudzbenice();
            dgvNarudzbenice.DataSource = narudzbenice;
            dgvNarudzbenice.Columns[5].Visible = false;
            dgvNarudzbenice.Columns[6].Visible = false;
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            Sortiraj(cmbSortiraj.SelectedIndex);
        }

        private void Sortiraj(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    SortirajPoDatumu();
                    break;
                case 1:
                    SortirajPoBrojuStavkiNajmanji();
                    break;
                case 2:
                    SortirajPoBrojuStavkiNajveci();
                    break;
                case 3:
                    SortirajPoIznosuNajmanji();
                    break;
                case 4:
                    SortirajPoIznosuNajveci();
                    break;
                default:
                    break;
            }
        }

        private void SortirajPoIznosuNajveci()
        {
            var sortiranoPoIznosuNajveci = servisNarudzbenice.SortirajPoIznosuNajveci();
            dgvNarudzbenice.DataSource = sortiranoPoIznosuNajveci;
        }

        private void SortirajPoIznosuNajmanji()
        {
            var sortiranoPoIznosuNajmanji = servisNarudzbenice.SortirajPoIznosuNajmanji();
            dgvNarudzbenice.DataSource = sortiranoPoIznosuNajmanji;
        }

        private void SortirajPoBrojuStavkiNajveci()
        {
            var sortiranoPoBrojuNajveci = servisNarudzbenice.SortirajPoBrojuStavkiNajveci();
            dgvNarudzbenice.DataSource = sortiranoPoBrojuNajveci;
        }

        private void SortirajPoBrojuStavkiNajmanji()
        {
            var sortiranoPoBrojuNajmanji = servisNarudzbenice.SortirajPoBrojuStavkiNajmanji();
            dgvNarudzbenice.DataSource = sortiranoPoBrojuNajmanji;
        }

        private void SortirajPoDatumu()
        {
            var sortiranoPoDatumu = servisNarudzbenice.SortirajPoDatumu();
            dgvNarudzbenice.DataSource= sortiranoPoDatumu;
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            var selektiranaNarudzbenica = dgvNarudzbenice.CurrentRow.DataBoundItem as narudzbenica;

            var frmStavkeNarudzbenice = new FrmStavkeNarudzbenice(selektiranaNarudzbenica);
            
            Hide();
            frmStavkeNarudzbenice.ShowDialog();
            Close();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var selektiranaNarudzbenica = dgvNarudzbenice.CurrentRow.DataBoundItem as narudzbenica;
            var frmIzvjestaj = new FrmIzvjestajNarudzbenica(selektiranaNarudzbenica);
            frmIzvjestaj.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new FrmIzbornikRacunovodstvo();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void FrmNarudzbenice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "PregledNarudzbenica");
        }
    }
}
