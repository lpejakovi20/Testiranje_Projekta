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
using EntitiesLayer.Entities;
using FaceRecognitionDotNet;

namespace E_ugostiteljstvo
{
    ///<author>Matej Ritoša</author>
    public partial class MainForm : Form
    {


        byte[] imageBytes;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private const string BaseDirectoryName = "source\\repos\\tkipp-nparag20-mritosa20-lpejakovi20\\Software\\E-ugostiteljstvo\\FaceRec";
        private const string ModelsDirectoryName = "source\\repos\\tkipp-nparag20-mritosa20-lpejakovi20\\Software\\E-ugostiteljstvo\\E-ugostiteljstvo\\bin\\Debug\\models";
        private string baseDirectory;
        private string modelsDirectory;
        int departmentCheck;

        public MainForm()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
            baseDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), BaseDirectoryName);
            modelsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ModelsDirectoryName);
            this.HelpRequested += MainForm_HelpRequested;

            if (!Directory.Exists(baseDirectory)) {
                Directory.CreateDirectory(baseDirectory);
            }

            if (!Directory.Exists(modelsDirectory)) {
                Directory.CreateDirectory(modelsDirectory);
            }
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
                    PrebaciNaKuhinju();

                }
                else if (zaposlenik.uloga_id == 1)
                {
                    PrebaciNaRacunovodstvo();

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
            string models = modelsDirectory;
            FaceRecognition faceRecognition;
            faceRecognition = FaceRecognition.Create(models);


            PretvoriUByteArray();

            var servisZaposlenici = new ZaposlenikServices(new ZaposlenikRepository());
            var zaposlenici = servisZaposlenici.GetZaposlenici();


            for (int i = 0; i < zaposlenici.Count; i++) {


                string fileName = $"{i}.jpg";
                string filePath = Path.Combine(baseDirectory, "Users\\"+fileName);
                
                File.WriteAllBytes(filePath, zaposlenici[i].slika);

                File.WriteAllText(Path.ChangeExtension(filePath, ".txt"), zaposlenici[i].uloga_id.ToString());


            }


            string fileName2 = "login.jpg";
            string directoryPath2 = Path.Combine(baseDirectory, "LoginUsers");
            string filePath2 = Path.Combine(directoryPath2, fileName2);
            File.WriteAllBytes(filePath2, imageBytes);
            string imagePath = filePath2;
            IEnumerable<FaceEncoding> faceEncodings;
            using (Bitmap bitmap = new Bitmap(imagePath)) {
                var knownImage = FaceRecognition.LoadImage(bitmap);
                faceEncodings = faceRecognition.FaceEncodings(knownImage);
            }


            if (faceEncodings.Any()) {
                bool checkFace = PrepoznajLice(faceRecognition, zaposlenici, faceEncodings);
                if (checkFace) {
                    if (departmentCheck == 2) {
                        PrebaciNaKuhinju();

                    } else {
                        PrebaciNaRacunovodstvo();

                    }


                } else {
                    MessageBox.Show("Lice nije prepoznato! Pokušajte ponovo.");
                }

            } else {
                MessageBox.Show("No Face Detected");
            }
        }

        private void PrebaciNaRacunovodstvo() {
            var frmRacunovodstvo = new FrmIzbornikRacunovodstvo();
            Hide();
            frmRacunovodstvo.ShowDialog();
            Close();
        }

        private void PrebaciNaKuhinju() {
            var frmKuhinja = new FrmKatalogNamirnica();
            Hide();
            frmKuhinja.ShowDialog();
            Close();
        }

        private bool PrepoznajLice(FaceRecognition faceRecognition, List<zaposlenik> zaposlenici, IEnumerable<FaceEncoding> faceEncodings) {
            var knownEncoding = faceEncodings.First();
            var imageDirectory = Path.Combine(baseDirectory, "Users");

            var imagePaths = new List<string>();
            for (int i = 0; i < zaposlenici.Count() - 1; i++) {
                imagePaths.Add(Path.Combine(imageDirectory, i + ".jpg"));
            };
            bool checkFace = false;

            for (int i = 1; i < zaposlenici.Count; i++) {

                var path = Path.Combine(imageDirectory, i + ".jpg");

                var pathTxt = Path.Combine(imageDirectory, i + ".txt");
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

            return checkFace;
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
