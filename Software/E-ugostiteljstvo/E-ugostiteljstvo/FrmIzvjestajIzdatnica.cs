using BusinessLogicLayer.Services;
using EntitiesLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Repositories;

namespace E_ugostiteljstvo
{
    ///<author>Lovro Pejaković</author>
    public partial class FrmIzvjestajIzdatnica : Form
    {
        public FrmIzvjestajIzdatnica()
        {
            InitializeComponent();
        }

        private void FrmIzvjestajIzdatnica_Load(object sender, EventArgs e)
        {
            stavkaIzdatniceBindingSource.DataSource = StavkaIzdatniceRepository.lista.ToList();

            var servisZaposlenik = new ZaposlenikServices(new ZaposlenikRepository());
            var logiraniZaposlenik = servisZaposlenik.GetZaposlenikById(LogiraniZaposlenik.Id);

            zaposlenikBindingSource.DataSource = logiraniZaposlenik;

            this.reportViewer1.RefreshReport();
        }
    }
}
