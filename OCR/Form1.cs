using Tesseract;

namespace OCR
{
    public partial class Form1 : Form
    {
        const string TITLE = "Form1";

        public string imagePath;

        public Form1(string imagePath)
        {
            System.Diagnostics.Debug.WriteLine($"[{TITLE}#Form1]");

            InitializeComponent();

            this.imagePath = imagePath;
            this.labelFilename.Text = "Filename: " + this.imagePath;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonSelectFile_Click] --START");

            this.openFileDialog1 = new OpenFileDialog
            {
                Multiselect = false,
                Title = "Please select a image",
                Filter = "Image|*.png;*.jpeg;*.jpg"
            };

            using (openFileDialog1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.imagePath = openFileDialog1.FileName;
                    System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonSelectFile_Click] imagePath: " + this.imagePath);

                    this.labelFilename.Text = "Filename: " + this.imagePath;
                    this.pictureBox1.Load(this.imagePath);
                }
            }

            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonSelectFile_Click] --STOP");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] --START");

            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] imagePath: " + this.imagePath);

            try
            {
                using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(this.imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            var text = page.GetText();
                            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] text: " + text);

                            var precisionRate = page.GetMeanConfidence();
                            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] precisionRate: " + precisionRate);

                            this.textBoxOutput.Text = text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] Exception: " + ex.Message);
            }

            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] --STOP");
        }
    }
}