using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator_WinForms
{
    public partial class SplashScreen : Form
    {
        private int progress = 0;
        private string[] messages = new string[]
        {
            "Waking up the hamsters...",
            "Teaching calculator basic math...",
            "Downloading more RAM...",
            "dun dun dunnnn...",
            "Downloading new Graphics Card (RTX 5090)...",
            "Installing unnecessary features...",
            "oi oi oi a eye eye...",
            "Wet lang...",
            "Loading memes... this is important!",
            "Fixing bugs in code...",
            "3... 2... 1... Hapit najud...",
            "Downloading trojan...",
            "Chill lang... dili ni hax...",
            "Hapit na... Basin...",
            "Mana JUD!"
        };
        private int currentMessage = 0;
        private List<string> imageFiles = new List<string>();
        private Random rand = new Random();
        private int tickCount = 0;

        public SplashScreen()
        {
            InitializeComponent();
            LoadImages();
            ShowRandomImage();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tickCount++;

            if (progress < 20)
            {
                progress += 1;
            }
            else if (progress < 50)
            {
                progress += 2;
            }
            else if (progress < 80)
            {
                progress += 1;
            }
            else
            {
                progress += 1;
            }

            if (progress > 100)
            {
                progress = 100;
            }

            progressBar1.Value = progress;

            if (tickCount % 40 == 0 && imageFiles.Count > 0)
            {
                ShowRandomImage();
            }

            int messageNumber = progress / 7;
            if (messageNumber < messages.Length && messageNumber != currentMessage)
            {
                currentMessage = messageNumber;
                loadingLabel.Text = messages[currentMessage];
            }

            if (progress >= 100)
            {
                timer1.Stop();
                System.Threading.Thread.Sleep(300);
                
                CalculatorForm mainForm = new CalculatorForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void LoadImages()
        {
            try
            {
                string imgPath1 = Path.Combine(Application.StartupPath, "img");
                string imgPath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "img");

                string imgFolder = "";
                if (Directory.Exists(imgPath1))
                {
                    imgFolder = imgPath1;
                }
                else if (Directory.Exists(Path.GetFullPath(imgPath2)))
                {
                    imgFolder = Path.GetFullPath(imgPath2);
                }

                if (imgFolder != "")
                {
                    string[] pngFiles = Directory.GetFiles(imgFolder, "*.png");
                    string[] jpgFiles = Directory.GetFiles(imgFolder, "*.jpg");
                    string[] jpeFiles = Directory.GetFiles(imgFolder, "*.jpe");
                    
                    imageFiles.AddRange(pngFiles);
                    imageFiles.AddRange(jpgFiles);
                    imageFiles.AddRange(jpeFiles);
                }
            }
            catch
            {
                imageFiles.Clear();
            }
        }

        private void ShowRandomImage()
        {
            try
            {
                if (imageFiles.Count > 0)
                {
                    int randomNum = rand.Next(imageFiles.Count);
                    string imagePath = imageFiles[randomNum];

                    if (File.Exists(imagePath))
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                        }
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.Visible = true;
                    }
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
            catch
            {
                pictureBox1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
