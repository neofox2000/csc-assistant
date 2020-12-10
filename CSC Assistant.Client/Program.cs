using System;
using System.Windows.Forms;
using CSC_Assistant.Client.Forms;
using CSC_Assistant.Client.Data;
using CSC_Assistant.Common.DataStructures;

namespace CSC_Assistant.Client
{
    static class Program
    {
        public static string appDataPathLocalLow;
        public static string outputPath;
        public static Action<Item> OnShowItemDetails;
        public static Action<Item> OnShowItemUsedIn;
        public static Action OnLocalItemDbUpdated;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                outputPath = Application.LocalUserAppDataPath;
                appDataPathLocalLow = 
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