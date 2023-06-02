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
    ///<author>Lovro Pejaković, Matej Ritoša, Nikola Parag</author>
    public partial class FrmIzbornikRacunovodstvo : Form
    {
        public FrmIzbornikRacunovodstvo()
        {
            InitializeComponent();
            this.HelpRequested += FrmIzbornikRacunovodstvo_HelpRequested;
        }

        private void btnPregledNarudzbenica_Click(object sender, EventArgs e)
        {
            var frmNarudzbenice = new FrmNarudzbenice();
            Hide();
            frmNarudzbenice.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FrmStatistikaIskoristenosti();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new MainForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FrmIzvjestajBlizuRok();
            
            form.ShowDialog();
            
        }

        private void FrmIzbornikRacunovodstvo_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "IzbornikRacunovodstva");
        }
    }
}
