using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using System.Windows.Forms;
using System.IO;

namespace OCR
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "Please select a image",
                Filter = "Image|*.png;*.jpeg;*.jpg"
            };

            using (dialog)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var imgPath = dialog.FileName;
                    Console.WriteLine("imgPath: " + imgPath);
                }
            }
        }
    }
}