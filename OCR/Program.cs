namespace OCR
{
    internal static class Program
    {
        const string TITLE = "Program";

        [STAThread]
        static void Main()
        {
            System.Diagnostics.Debug.WriteLine($"[{TITLE}#Main]");

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(imagePath: "--"));
        }
    }
}