namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormKayitlar kayitFormu = new FormKayitlar(); 
            Form1 rezervasyonFormu = new Form1(kayitFormu); 
            Application.Run(new FormGiris());
        }
    }
}