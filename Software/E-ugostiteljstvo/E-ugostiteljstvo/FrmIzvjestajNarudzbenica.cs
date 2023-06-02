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
using EntitiesLayer.Entities;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class FrmIzvjestajNarudzbenica : Form
    {
        private narudzbenica SelektiranaNarudzbenica;
        NarudzbenicaServices servisNarudzbenice = new NarudzbenicaServices();
        KatalogNamirnicaServices servisKatalog = new KatalogNamirnicaServices();
        ZaposlenikServices servisZaposlenik = new ZaposlenikServices();

        public FrmIzvjestajNarudzbenica(narudzbenica _narudzbenica)
        {
            SelektiranaNarudzbenica = _narudzbenica;
            InitializeComponent();
        }

        private void FrmIzvjestajNarudzbenica_Load(object sender, EventArgs e)
        {
            var idNarudzbenice = SelektiranaNarudzbenica.id;
            var stavkeNarudzbenice = servisKatalog.GetStavkeNarudzbenice(idNarudzbenice);
            namirnicaukataloguBindingSource.DataSource = stavkeNarudzbenice;
            namirnicanarudzbenicaBindingSource.DataSource = stavkeNarudzbenice;

            var selektiranaNarudzbenica = servisNarudzbenice.GetNarudzbenicaById(idNarudzbenice);
            narudzbenicaBindingSource.DataSource = selektiranaNarudzbenica;

            var idZaposlenika = SelektiranaNarudzbenica.zaposlenik_id;
            var kreiraoZaposlenik = servisZaposlenik.GetZaposlenikNarudzbenice(idZaposlenika.GetValueOrDefault());
            zaposlenikBindingSource.DataSource = kreiraoZaposlenik;

            

            this.reportViewer.RefreshReport();
        }
    }
}
