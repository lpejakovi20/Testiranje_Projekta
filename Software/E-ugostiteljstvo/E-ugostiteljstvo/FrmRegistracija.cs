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
using DataAccessLayer.Repositories;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class FrmRegistracija : Form
    {
        byte[] imageBytes;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        public FrmRegistracija()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
            this.HelpRequested += FrmRegistracija_HelpRequested;
        }

        private void btnSlikaj_Click(object sender, EventArgs e)
        {
            pcbSlika2.Image = pcbSlika.Image;
            Bitmap bitmap = new Bitmap(pcbSlika2.Width, pcbSlika2.Height);
            pcbSlika2.DrawToBitmap(bitmap, pcbSlika2.ClientRectangle);
            //System.Drawing.Imaging.ImageFormat imageFormat = null;
            //imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;

            using (var stream = new MemoryStream()) {
                bitmap.Save(stream, ImageFormat.Jpeg);
                imageBytes = stream.ToArray();
            }
            pcbSlika2.Image = bitmap;
        }

       

        private void btnUkljuci_Click(object sender, EventArgs e)
        {
            startCamera();
        }

        private void startCamera() {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += Camera_On;
            captureDevice.Start();

        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs) {
            pcbSlika.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
         

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
                var zaposlenikServices = new ZaposlenikServices(new ZaposlenikRepository());
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

        private void FrmRegistracija_Load(object sender, EventArgs e) {
            UcitajUloge();
            PostavljanjeIzboraKamere();
        }

        private void PostavljanjeIzboraKamere() {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) {
                cboDevices.Items.Add(filterInfo.Name);
            }
            cboDevices.SelectedIndex = 0;
        }

        private void UcitajUloge()
        {
            var ulogaServices = new UlogaServices(new UlogaRepository());
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
