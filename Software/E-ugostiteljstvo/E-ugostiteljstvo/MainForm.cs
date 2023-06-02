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
using EntitiesLayer;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
            this.HelpRequested += MainForm_HelpRequested;


        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var servisZaposlenik = new ZaposlenikServices();
            var zaposlenik = servisZaposlenik.GetZaposlenikByEmail(txtEmail.Text);


            if (zaposlenik == null)
            {
                MessageBox.Show("Pogrešni podaci!");
            }
            else if (zaposlenik.lozinka != txtLozinka.Text)
            {
                MessageBox.Show("Pogrešna lozinka!");
            }
            else
            {
                LogiraniZaposlenik.Id = zaposlenik.id;
                if (zaposlenik.uloga_id == 2)
                {
                    var frmKuhinja = new FrmKatalogNamirnica();
                    Hide();
                    frmKuhinja.ShowDialog();
                    Close();

                }
                else if (zaposlenik.uloga_id == 1)
                {
                    var frmRacunovodstvo = new FrmIzbornikRacunovodstvo();
                    Hide();
                    frmRacunovodstvo.ShowDialog();
                    Close();

                }

            }
        }

        private void btnRegistracija_Click_1(object sender, EventArgs e)
        {
            var form = new FrmRegistracija();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "Prijava");
        }
    }
}
