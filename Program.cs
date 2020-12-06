using System;
using System.Windows.Forms;
using CSC_Assistant.Forms;

namespace CSC_Assistant
{
    static class Program
    {
        public static string appDataPath;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                appDataPath = 
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                        .Replace("Roaming", "LocalLow");
            }
            catch { };

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}