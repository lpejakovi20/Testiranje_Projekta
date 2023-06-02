using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System.IO;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class FrmRegistracija : Form
    {
        private Capture snimkaLica = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool detektiranoLice = false;
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Rectangle[] lica;
        private Image<Bgr, byte> faceImage = null;

        public FrmRegistracija()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
            this.HelpRequested += FrmRegistracija_HelpRequested;
        }

        private void btnSlikaj_Click(object sender, EventArgs e)
        {
            if (detektiranoLice)
            {
                
                Rectangle lice = lica[0];


                faceImage = currentFrame.GetSubRect(lice);


                snimkaLica.Stop();
                detektiranoLice = false;

                MessageBox.Show("Face captured and saved successfully.");
            }
            else
            {
                MessageBox.Show("No face detected. Please try again.");
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            snimkaLica.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(pcbSlika.Width, pcbSlika.Height, Inter.Cubic);
            detektiranoLice = true;
            if (true)
             {
                 Mat grayImage = new Mat();
                 CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);


                 lica = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);


                if (lica.Length>0)
                {
                    foreach (var lice in lica)
                    {
                        CvInvoke.Rectangle(currentFrame, lice, new Bgr(Color.Red).MCvScalar, 2);
                    }
                }
                
            }
            
            
            pcbSlika.Image = currentFrame.Bitmap;
        }

        private void btnUkljuci_Click(object sender, EventArgs e)
        {
            snimkaLica = new Capture();
            snimkaLica.ImageGrabbed += ProcessFrame;
            snimkaLica.Start();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            if (faceImage != null)
            {
                faceImage.Bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            
            
            byte[] imageBytes = memoryStream.ToArray();

            var _zaposlenik = new zaposlenik
            {
                ime = txtIme.Text,
                prezime = txtPrezime.Text,
                email = txtEmail.Text,
                lozinka = txtLozinka.Text,
                uloga = cmbRadnoMjesto.SelectedItem as uloga,
                slika = imageBytes,
                
                
            };

            if (validacijaMail(txtEmail.Text) && txtLozinka.Text.Length >= 6)
            {
                var zaposlenikServices = new ZaposlenikServices();
                zaposlenikServices.AddZaposlenik(_zaposlenik);
                Close();
            }
            else
            {
                MessageBox.Show("Krivo upisani podaci.");
            }

            var frmLogin = new MainForm();
            Hide();
            frmLogin.ShowDialog();
            Close();
          
        }

        private bool validacijaMail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            UcitajUloge();
        }

        private void UcitajUloge()
        {
            var ulogaServices = new UlogaServices();
            var uloge = ulogaServices.GetUloge();
            cmbRadnoMjesto.DataSource = uloge;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new MainForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void FrmRegistracija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "..\\..\\HelpCHM\\Help.chm", HelpNavigator.KeywordIndex, "Registracija");
        }
    }
}
