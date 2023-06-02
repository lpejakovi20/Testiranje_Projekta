using BusinessLogicLayer.Services;
using EntitiesLayer;
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
    public partial class FrmStatistikaIskoristenosti : Form
    {
        public FrmStatistikaIskoristenosti()
        {
            InitializeComponent();
            this.HelpRequested += FrmStatistikaIskoristenosti_HelpRequested;
        }

        private void FrmStatistikaIskoristenosti_Load(object sender, EventArgs e)
        {
            txtSveukupnaVrijednost.Enabled = false;

            var servis = new NamirnicaServices();
            var listaNamirnica = servis.GetNamirniceIstecenogRoka();

            dgvNamirniceIstekaoRok.DataSource = listaNamirnica;

            decimal sveukupno = 0;

            foreach (DataGridViewRow row in dgvNamirniceIstekaoRok.Rows)
            {
                sveukupno += decimal.Parse(row.Cells[7].Value.ToString());   
            }

            dgvNamirniceIstekaoRok.Columns[7].Visible = false;

            txtSveukupnaVrijednost.Text = Math.Round(sveukupno, 2).ToString() + "€";


            var mjeseci = new List<string> {"siječanj","veljača","ožujak","travanj","svibanj","lipanj","srpanj","kolovoz","rujan","listopad","studeni","prosinac"};

            var trenutniMjesec = DateTime.Today.Month;
            cmbMjesec.DataSource = mjeseci.Take(trenutniMjesec).ToList();
            cmbMjesec.SelectedIndex = 0;
        }

        private void cmbMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mjesec = cmbMjesec.SelectedIndex + 1;
            var godina = DateTime.Today.Year;

            var service = new IskoristenostNamirnicaServices();

            var iskoristenostNamirnica = service.GetIskoristeneNamirniceByMonth(mjesec,godina);
            dgvIskoristenostNamirnica.DataSource = iskoristenostNamirnica;

            if(dgvIskoristenostNamirnica.Rows.Count > 0)
            {
                dgvIskoristenostNamirnica.Columns["namirnica_u_katalogu_id"].HeaderText = "namirnica_id";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new FrmIzbornikRacunovodstvo();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void FrmStatistikaIskoristenosti_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "Statistika");
        }

        private void btnReportIskoristenost_Click(object sender, EventArgs e)
        {
            var form = new FrmIzvjestajIskoristenostNamirnica(LogiraniZaposlenik.Id, cmbMjesec.SelectedIndex + 1);
            form.ShowDialog();
        }
    }
}
