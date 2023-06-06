using BusinessLogicLayer.Services;
using DataAccessLayer;
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

namespace E_ugostiteljstvo
{
    ///<author>Lovro Pejaković</author>
    public partial class FrmStavkeIzdatnice : Form
    {
        public FrmStavkeIzdatnice()
        {
            InitializeComponent();
            this.HelpRequested += FrmStavkeIzdatnice_HelpRequested;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajStavkuIzdatnice form = new FrmDodajStavkuIzdatnice();
            form.ShowDialog();
            OsvjeziStavkeIzdatnice();
        }

        private void FrmStavkeIzdatnice_Load(object sender, EventArgs e)
        {
            StavkaIzdatniceRepository.lista = new List<StavkaIzdatnice>();
            OsvjeziStavkeIzdatnice();
        }

        public void OsvjeziStavkeIzdatnice()
        {
            var stavke = StavkaIzdatniceRepository.GetList();
            dgvStavkeIzdatnice.DataSource = stavke.ToList();
            dgvStavkeIzdatnice.Columns[1].Visible = false;

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if(dgvStavkeIzdatnice.CurrentRow != null)
            {
                var odabranaStavka = dgvStavkeIzdatnice.CurrentRow.DataBoundItem as StavkaIzdatnice;
                StavkaIzdatniceRepository.lista.RemoveAll(s => s.Temp_id == odabranaStavka.Temp_id);
                OsvjeziStavkeIzdatnice();
            }
            else
            {
                MessageBox.Show("Nije moguće ukloniti stavku ukoliko nije odabrana!");
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            if(dgvStavkeIzdatnice.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvStavkeIzdatnice.Rows)
                {
                    StavkaIzdatnice namirnica = row.DataBoundItem as StavkaIzdatnice;

                    var novaNamirnica = new namirnica
                    {
                        kolicina = namirnica.Kolicina,
                        rok = namirnica.Rok_trajanja,
                        namirnica_u_katalogu_id = namirnica.Id
                    };

                    var servis = new NamirnicaServices();
                    servis.UpdateNamirnica(novaNamirnica);

                    var servisIskoristenostNamirnica = new IskoristenostNamirnicaServices(new IskoristenostNamirnicaRepository());
                    var mjesec = DateTime.Today.Month;
                    var godina = DateTime.Today.Year;

                    var mjesecString = "";

                    var datum = "";
                    if (mjesec < 10) mjesecString = "0" + mjesec;
                    else mjesecString = mjesec.ToString();

                    datum = godina + "-" + mjesecString + "-01";

                    var postojeca = servisIskoristenostNamirnica.GetIskoristeneNamirniceByMonth(mjesec,godina);

                    var nova = new iskoristenost_namirnice()
                    {
                        iskoristeno = novaNamirnica.kolicina,
                        namirnica_u_katalogu_id = novaNamirnica.namirnica_u_katalogu_id,
                        datum = DateTime.Parse(datum)
                    };

                    if (postojeca.Count > 0)
                    {
                        servisIskoristenostNamirnica.UpdateIskoristenostNamirnice(nova);
                    }
                    else
                    {
                        servisIskoristenostNamirnica.AddIskoristenostNamirnice(nova);
                    }
                }
                var form = new FrmIzvjestajIzdatnica();
                form.Show();
                StavkaIzdatniceRepository.lista.Clear();
                OsvjeziStavkeIzdatnice();
            }
            else
            {
                MessageBox.Show("Nije unešena niti jedna stavka!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new FrmKatalogNamirnica();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void FrmStavkeIzdatnice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "StavkeIzdatnice");
        }
    }
}
