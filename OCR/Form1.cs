namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
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
                    var imgPath = openFileDialog1.FileName;
                    System.Diagnostics.Debug.WriteLine("imgPath: " + imgPath);

                    this.labelFilename.Text = imgPath;
                    this.pictureBox1.Load(imgPath);
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

        }
    }
}