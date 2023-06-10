using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer;
using FaceRecognitionDotNet;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class MainForm : Form
    {


        byte[] imageBytes;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        int departmentCheck;

        public MainForm()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
            this.HelpRequested += MainForm_HelpRequested;


        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var servisZaposlenik = new ZaposlenikServices(new ZaposlenikRepository());
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

        private void btnCapture_Click(object sender, EventArgs e) {
            startCamera();
        }

        private void startCamera() {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += Camera_On;
            captureDevice.Start();

        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs) {
            pcbUser.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) {
                cboDevices.Items.Add(filterInfo.Name);
            }
            cboDevices.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e) {
            string models = "C:/Users/38599/source/repos/rpp22-mritosa20-nparag20-lpejakovi20/Software/E-ugostiteljstvo/E-ugostiteljstvo/bin/Debug/models";
            FaceRecognition faceRecognition;
            faceRecognition = FaceRecognition.Create(models);


            PretvoriUByteArray();

            var servisZaposlenici = new ZaposlenikServices(new ZaposlenikRepository());
            var zaposlenici = servisZaposlenici.GetZaposlenici();


            for (int i = 0; i < zaposlenici.Count; i++) {
                string fileName = $"{i}.jpg";
                string filePath = Path.Combine("C:/Users/38599/source/repos/rpp22-mritosa20-nparag20-lpejakovi20/Software/E-ugostiteljstvo/Users", fileName);




                File.WriteAllBytes(filePath, zaposlenici[i].slika);

                File.WriteAllText(Path.ChangeExtension(filePath, ".txt"), zaposlenici[i].uloga_id.ToString());


            }


            string fileName2 = "login.jpg";
            string directoryPath2 = @"C:\Users\38599\source\repos\rpp22-mritosa20-nparag20-lpejakovi20\Software\E-ugostiteljstvo\LoginUsers";
            string filePath2 = Path.Combine(directoryPath2, fileName2);
            File.WriteAllBytes(filePath2, imageBytes);
            string imagePath = @"C:\Users\38599\source\repos\rpp22-mritosa20-nparag20-lpejakovi20\Software\E-ugostiteljstvo\LoginUsers\login.jpg";
            IEnumerable<FaceEncoding> faceEncodings;
            using (Bitmap bitmap = new Bitmap(imagePath)) {
                var knownImage = FaceRecognition.LoadImage(bitmap);
                faceEncodings = faceRecognition.FaceEncodings(knownImage);
            }


            if (faceEncodings.Any()) {
                var knownEncoding = faceEncodings.First();

                var imagePaths = new List<string>();
                for (int i = 0; i < zaposlenici.Count() - 1; i++) {
                    imagePaths.Add("C:/Users/38599/source/repos/rpp22-mritosa20-nparag20-lpejakovi20/Software/E-ugostiteljstvo/Users/" + i + ".jpg");
                };
                bool checkFace = false;

                for (int i = 1; i < zaposlenici.Count; i++) {

                    var path = "C:/Users/38599/source/repos/rpp22-mritosa20-nparag20-lpejakovi20/Software/E-ugostiteljstvo/Users/" + i + ".jpg";
                    var pathTxt = "C:/Users/38599/source/repos/rpp22-mritosa20-nparag20-lpejakovi20/Software/E-ugostiteljstvo/Users/" + i + ".txt";
                    using (Bitmap bitmapCompare = new Bitmap(path)) {
                        var imageToCompare = FaceRecognition.LoadImage(bitmapCompare);
                        var encodingsToCompare = faceRecognition.FaceEncodings(imageToCompare);
                        string department = File.ReadAllText(pathTxt);

                        if (bitmapCompare != null) {


                            foreach (var encodingToCompare in encodingsToCompare) {
                                var compare = FaceRecognition.CompareFace(knownEncoding, encodingToCompare);
                                if (compare) {
                                    if (department == "1") {
                                        departmentCheck = 1;
                                    } else {
                                        departmentCheck = 2;
                                    }
                                    checkFace = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (checkFace == true) {
                        break;
                    }
                }
                if (checkFace) {
                    if (departmentCheck == 2) {
                        var frmKuhinja = new FrmKatalogNamirnica();
                        Hide();
                        frmKuhinja.ShowDialog();
                        Close();

                    } else {
                        var frmRacunovodstvo = new FrmIzbornikRacunovodstvo();
                        Hide();
                        frmRacunovodstvo.ShowDialog();
                        Close();

                    }


                } else {
                    MessageBox.Show("Lice nije prepoznato! Pokušajte ponovo.");
                }

            } else {
                MessageBox.Show("No Face Detected");
            }
        }

        private void PretvoriUByteArray() {
            Bitmap bitmap = new Bitmap(pcbUser.Width, pcbUser.Height);
            pcbUser.DrawToBitmap(bitmap, pcbUser.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;

            using (var stream = new MemoryStream()) {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = stream.ToArray();
            }
        }
    }
}
