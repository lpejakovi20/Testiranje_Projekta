using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BusinessLogicLayer.Services;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using ZXing;

namespace E_ugostiteljstvo
{
    ///<author>Lovro Pejaković</author>
    public partial class FrmDodajStavkuIzdatnice : Form
    {
        public FrmDodajStavkuIzdatnice()
        {
            InitializeComponent();
            this.HelpRequested += FrmDodajStavkuIzdatnice_HelpRequested;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void FrmDodajStavkuIzdatnice_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNaziv.Enabled = false;
            txtVrsta.Enabled = false;

            cmbRokTrajanja.DropDownStyle = ComboBoxStyle.DropDownList;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevices.Items.Add(filterInfo.Name);
            }
            cboDevices.SelectedIndex = 0;
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FrmDodajStavkuIzdatnice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
            
        }

        private void UgasiKameru()
        {
            timer1.Stop();
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        namirnica_u_katalogu namirnicaKatalog;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if(result != null)
                {
                    var servis = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
                    
                    var isNumeric = int.TryParse(result.ToString(), out _);
                    if (isNumeric)
                    {
                        namirnicaKatalog = servis.GetKatalogNamirnicaById(Int32.Parse(result.ToString()));
                        
                        if(namirnicaKatalog != null)
                        {
                            txtId.Text = result.ToString();
                            txtNaziv.Text = namirnicaKatalog.naziv;
                            txtVrsta.Text = namirnicaKatalog.vrsta;

                            var servisNamirnica = new NamirnicaServices(new NamirnicaRepository());
                            var namirnice = servisNamirnica.GetNamirniceById(Int32.Parse(result.ToString()));

                            cmbRokTrajanja.DataSource = namirnice;
                            cmbRokTrajanja.SelectedIndex = 0;
                        }
                    }
                    UgasiKameru();
                    if (!isNumeric || namirnicaKatalog == null)
                    {
                        pictureBox1.Image = null;
                        MessageBox.Show("Skenirani kod ne pripada niti jednoj od postojećih namirnica!");
                    }
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Potrebno je skenirati QR kod nammirnice!");
            }
            else if (txtKolicina.Text == "")
            {
                MessageBox.Show("Potrebno je unijeti količinu!");
            }
            else if(Int32.Parse(txtKolicina.Text) < 0)
            {
                MessageBox.Show("Količina mora biti pozitivan broj!");
            }
            else
            {
                var selected = cmbRokTrajanja.SelectedItem as namirnica;

                var ukupnaKolicina = 0;
                var listaPostojecih = StavkaIzdatniceRepository.lista.FindAll(n => n.Rok_trajanja == selected.rok);

                if (listaPostojecih != null)
                {
                    foreach (var nam in listaPostojecih)
                    {
                        ukupnaKolicina += nam.Kolicina;
                    }
                }
                var total = ukupnaKolicina + Int32.Parse(txtKolicina.Text);

                if (total > selected.kolicina)
                {
                    MessageBox.Show("Nema dovoljne količine odabrane namirnice, dostupna količina = " + (selected.kolicina - ukupnaKolicina));
                }
                else if (selected.kolicina < Int32.Parse(txtKolicina.Text))
                {
                    MessageBox.Show("Nema dovoljne količine odabrane namirnice, dostupna količina = " + selected.kolicina);
                }
                else
                {
                    StavkaIzdatnice novaStavka = new StavkaIzdatnice(Int32.Parse(txtId.Text), txtNaziv.Text, txtVrsta.Text, Int32.Parse(txtKolicina.Text), namirnicaKatalog.mjerna_jedinica, selected.rok,GenerateRandomnumber());
                    StavkaIzdatniceRepository.AddToList(novaStavka);
                    Hide();
                    Close();
                }
            }
        }

        private int GenerateRandomnumber()
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            var tempstring = milliseconds.ToString();
            tempstring = tempstring.Substring(5);
            int random = int.Parse(tempstring);
            return random;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void FrmDodajStavkuIzdatnice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "DodajStavkuIzdatnice");
        }
    }
}
