using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing;
using EntitiesLayer.Entities;
using BusinessLogicLayer.Services;
using System.Drawing.Imaging;
using System.IO;
using EntitiesLayer;
using DataAccessLayer.Repositories;

namespace E_ugostiteljstvo
{
    ///<author>Nikola Parag</author>
    public partial class FrmDodajNamirnicuUKatalog : Form
    {
        int value = 0;
        Bitmap qrCode = null;
        public FrmDodajNamirnicuUKatalog()
        {
            InitializeComponent();
            this.HelpRequested += FrmDodajNamirnicuUKatalog_HelpRequested;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            value = GenerateRandomnumber();
            qrCode = GenerateQRCode(value);
            pcbQR.Image = qrCode;
        }

        private Bitmap GenerateQRCode(int value)
        {
            QrCodeEncodingOptions options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 200,
                Height = 200,
            };
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;

            qrCode = writer.Write(value.ToString());


            return qrCode;
        }

        private int GenerateRandomnumber()
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            var tempstring = milliseconds.ToString();
            tempstring = tempstring.Substring(5);
            int random = int.Parse(tempstring);
            return random;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || cmbVrstanNamirnice.SelectedIndex == -1 || txtMinZalihe.Text == "" || txtOptZalihe.Text == "" || cmbMjJed.SelectedIndex == -1 || txtRokUporabe.Text == "" )
            {
                MessageBox.Show("Unesite sve podatke o novoj namirnice");
            }
            else if (value == 0)
            {
                MessageBox.Show("Generirajte QR kod");
            }
            else
            {

                string directoryPath = @"C:\NamirniceQr";

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                
                string filePath = @"C:\NamirniceQr\qrCode_" + value.ToString() + ".png";
                qrCode.Save(filePath, ImageFormat.Png);

                var novaNamirnica = new namirnica_u_katalogu
                {
                    id = value,
                    naziv = txtNaziv.Text,
                    vrsta = cmbVrstanNamirnice.SelectedItem.ToString(),
                    minimalne_zalihe = int.Parse(txtMinZalihe.Text),
                    optimalne_zalihe = int.Parse(txtOptZalihe.Text),
                    mjerna_jedinica = cmbMjJed.SelectedItem.ToString(),
                    rok_uporabe = int.Parse(txtRokUporabe.Text),
                    cijena = decimal.Parse(txtCijena.Text),
                    zaposlenik_id = LogiraniZaposlenik.Id

                };

                var services = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());

                if (services.AddNamirnica(novaNamirnica))
                {
                    MessageBox.Show("Unešena nova namirnica");
                }
                else
                {
                    MessageBox.Show("Greška u unosu! Pokušajte ponovo!");
                }
                Close();
            }

            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDodajNamirnicuUKatalog_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "DodajNamirnicuUKatalog");
        }
    }
}
