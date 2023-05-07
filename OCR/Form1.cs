using IronOcr;

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

            var ocr = new IronTesseract();
            using (var input = new OcrInput(@"" + this.imagePath))
            {
                System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] input: " + input);

                var result = ocr.Read(input);
                System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] result: " + result);
                System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] result.Text: " + result.Text);

                this.textBoxOutput.Text = result.Text;
            }

            System.Diagnostics.Debug.WriteLine($"[{TITLE}#buttonRun_Click] --STOP");
        }
    }
}