using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
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
    ///<author>Nikola Parag</author>
    public partial class FrmIzvjestajBlizuRok : Form
    {
        NamirnicaServices services = new NamirnicaServices(new NamirnicaRepository());
        public FrmIzvjestajBlizuRok()
        {
            InitializeComponent();
        }

        private void FrmIzvjestajBlizuRok_Load(object sender, EventArgs e)
        {
            var izvjestajLista = services.GetNamirniceBlizuRoka();
            stavkaIzvjestajaBlizuRokaBindingSource.DataSource = izvjestajLista;
            this.reportViewerRok.RefreshReport();
        }


    }
}
