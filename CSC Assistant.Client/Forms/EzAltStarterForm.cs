using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSC_Assistant.Client.Forms
{
    public partial class EzAltStarterForm : Form
    {
        public EzAltStarterForm()
        {
            InitializeComponent();
        }

        private void MakeFilesButton_Click(object sender, EventArgs e)
        {
            // verify platform
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                MessageBox.Show("This function only works on Windows right now!");
                return;
            }

            //Validate exe
            if (!File.Exists(ExeTextBox.Text) || !ExeTextBox.Text.EndsWith(".exe"))
            {
                MessageBox.Show("Invalid exe file.");
                return;
            }

            //Validate output folder
            if (!Directory.Exists(OutputFolderTextBox.Text))
            {
                MessageBox.Show("Invalid output folder.");
                return;
            }

            using RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LucidSight, Inc\CSC-Alpha");
            if (key == null)
            {
                MessageBox.Show("Could not find the game registry entries - you may have too stronk security, or game is not installed!");
                return;
            }

            //Setup the registry file and write to output folder
            string[] outputLines = new string[] {
                "Windows Registry Editor Version 5.00",
                string.Empty,
                "[HKEY_CURRENT_USER\\Software\\LucidSight, Inc\\CSC-Alpha]",
                MakeRegistryHex(key, "user_Protected_h1402120993"),
                MakeRegistryDWord(key, "user_ProtectedHash_h3844546803"),
                MakeRegistryHex(key, "password_Protected_h2139964655"),
                MakeRegistryDWord(key, "password_ProtectedHash_h1565198909"),
            };
            File.WriteAllLines($"{OutputFolderTextBox.Text}\\creds.reg", outputLines);

            //Setup the batch file and write to output folder
            outputLines = new string[]
            {
                $"reg import \"{OutputFolderTextBox.Text}\\creds.reg\"",
                $"start \"\" \"{ExeTextBox.Text}\""
            };
            File.WriteAllLines($"{OutputFolderTextBox.Text}\\Start CSC Alt.bat", outputLines);

            //Show user their new files
            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                Arguments = OutputFolderTextBox.Text,
                FileName = "explorer.exe",
            });
        }

        private void LocateExeButton_Click(object sender, EventArgs e)
        {
            if (OpenFileD.ShowDialog() == DialogResult.OK)
            {
                ExeTextBox.Text = OpenFileD.FileName;
                OutputFolderTextBox.Text = Path.GetDirectoryName(ExeTextBox.Text);
            }
        }

        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserD.ShowDialog() == DialogResult.OK)
            {
                OutputFolderTextBox.Text = FolderBrowserD.SelectedPath;
            }
        }

        private string MakeRegistryHex(RegistryKey key, string rkName)
        {
            var data = key.GetValue(rkName) as byte[];
            var strdata = BitConverter.ToString(data);
            return $"\"{rkName}\" = hex:{strdata.Replace("-", ",")}";
        }
        private string MakeRegistryDWord(RegistryKey key, string rkName)
        {
            int data = (int)key.GetValue(rkName);
            var strdata = data.ToString("X8");
            return $"\"{rkName}\" = dword:{strdata.Replace("-", "")}";
        }
    }
}
