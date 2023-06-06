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
using EntitiesLayer;
using EntitiesLayer.Entities;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class FrmStavkeNarudzbenice : Form
    {
        private narudzbenica SelektiranaNarudzbenica;

        KatalogNamirnicaServices servisKatalog = new KatalogNamirnicaServices();

        NarudzbenicaServices servisNarudzbenice = new NarudzbenicaServices(new NarudzbenicaRepository());
        public FrmStavkeNarudzbenice(narudzbenica _narudzbenica)
        {
            InitializeComponent();
            SelektiranaNarudzbenica = _narudzbenica;
            this.HelpRequested += FrmStavkeNarudzbenice_HelpRequested;
        }

        

        

        private void FrmStavkeNarudzbenice_Load(object sender, EventArgs e)
        {

            var idNarudzbenice = SelektiranaNarudzbenica.id;
            var stavkeNarudzbenice = servisKatalog.GetStavkeNarudzbenice(idNarudzbenice);
            dgvStavkeNarudzbenice.DataSource = stavkeNarudzbenice;

            var selektiranaNarudzbenica = servisNarudzbenice.GetNarudzbenicaById(idNarudzbenice);
            lblIznos.Text = selektiranaNarudzbenica.sveukupan_iznos.ToString() + "€";


        }

        private void btnIzradiPrimku_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvStavkeNarudzbenice.Rows)
            {
              

                DateTime trenutniDatum = DateTime.Now;

                var id = Int32.Parse(row.Cells[0].Value.ToString());

                var nova = new namirnica
                {
                    namirnica_u_katalogu_id = id,
                    kolicina = Int32.Parse(row.Cells[5].Value.ToString()),
                    rok = trenutniDatum
                };

                var servisNamirnica = new NamirnicaServices(new NamirnicaRepository());
                var servisNamirnicaKatalog = new KatalogNamirnicaServices();

                var namirnice = servisNamirnica.GetAll(id);
                var namirnicaKatalog = servisNamirnicaKatalog.GetKatalogNamirnicaById(id);

                var namirniceIstiDatum = namirnice.Find(n => n.rok.Date == nova.rok.AddDays(namirnicaKatalog.rok_uporabe).Date);

                if(namirniceIstiDatum == null)
                {
                    servisNamirnica.AddNamirnica(nova);
                }
                else
                {
                    nova.kolicina *= -1;
                    nova.rok = namirniceIstiDatum.rok;
                    servisNamirnica.UpdateNamirnica(nova);
                }
            }            

            var forma = new FrmIzvjestajPrimka(SelektiranaNarudzbenica);            
            forma.ShowDialog();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new FrmNarudzbenice();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void FrmStavkeNarudzbenice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "PregledStavkiNarudzbenice");
        }
    }
}
