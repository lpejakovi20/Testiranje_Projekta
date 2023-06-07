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
    ///<author>Lovro Pejaković</author>
    public partial class FrmIzvjestajPrimka : Form
    {
        private narudzbenica SelektiranaNarudzbenica;
        NarudzbenicaServices servisNarudzbenice = new NarudzbenicaServices(new NarudzbenicaRepository());
        KatalogNamirnicaServices servisKatalog = new KatalogNamirnicaServices();
        ZaposlenikServices servisZaposlenik = new ZaposlenikServices(new ZaposlenikRepository());
        KatalogNamirnicaServices servisKatalog = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
        ZaposlenikServices servisZaposlenik = new ZaposlenikServices();

        public FrmIzvjestajPrimka(narudzbenica _narudzbenica)
        {
            InitializeComponent();
            SelektiranaNarudzbenica = _narudzbenica;
        }

        private void FrmIzvjestajPrimka_Load(object sender, EventArgs e)
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

            this.reportViewer1.RefreshReport();
        }
    }
}
