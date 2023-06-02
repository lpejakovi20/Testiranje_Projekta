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

namespace E_ugostiteljstvo
{
    ///<author>Lovro Pejaković</author>
    public partial class FrmIzvjestajIskoristenostNamirnica : Form
    {
        private int idZaposlenika;
        private int odabraniMjesec;
        public FrmIzvjestajIskoristenostNamirnica(int id, int mjesec)
        {
            InitializeComponent();
            idZaposlenika = id;
            odabraniMjesec = mjesec;
        }

        private void FrmIzvjestajIskoristenostNamirnica_Load(object sender, EventArgs e)
        {
            var godina = DateTime.Today.Year;
            var servis = new IskoristenostNamirnicaServices();
            stavkaIskoristenostNamirniceBindingSource.DataSource = servis.GetIskoristeneNamirniceByMonth(odabraniMjesec,godina);

            var servisZaposlenik = new ZaposlenikServices();
            zaposlenikBindingSource.DataSource = servisZaposlenik.GetZaposlenikById(idZaposlenika);

            this.reportViewer1.RefreshReport();
        }
    }
}
