using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CSC_Assistant
{
    public partial class MainForm : Form
    {
        const string combatLogFileName = "CSC_Game_Logs.txt";
        const string miningLogFileName = "CSC_Mining_Logs.txt";

        struct GameLog
        {
            public DateTime lastEntry;
            public string path;
            public string[] lines;

            public GameLog(string path)
            {
                lastEntry = DateTime.MinValue;
                this.path = path;
                lines = null;
            }
            public bool Read()
            {
                //Bail if no log file is present
                if (!File.Exists(path)) return false;

                //Check logfile for changes
                var fileDT = File.GetLastWriteTime(path);

                //Bail if file hasn't been written since last read
                if (fileDT < lastEntry) return false;

                //Attempt to read entire log file - bail on error
                try
                {
                    lines = File.ReadAllLines(path);
                    lastEntry = DateTime.Now;
                }
                catch
                {
                    return false;
                }

                return true;
            }
            public void Display(RichTextBox omissions, RichTextBox outputTB, bool collapsedMode)
            {
                //Bail if nothing to do
                if ((lines == null) || (lines.Length < 1)) return;

                //Collapsed/grouped log mode
                List<string> modifiedLines = new List<string>();
                int dupeCount = 1;
                string lastLine = string.Empty;

                outputTB.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    //Ignore empty lines
                    if (lines[i] == string.Empty) continue;

                    //Ignore lines in the omission list
                    bool foundOmission = false;
                    for (int j = 0; j < omissions.Lines.Length; j++)
                    {
                        if (lines[i].Contains(omissions.Lines[j]))
                        {
                            foundOmission = true;
                            break;
                        }
                    }
                    if (foundOmission) continue;

                    if (collapsedMode)
                    {
                        //Count duplicate lines until the next unique line
                        if (lines[i] == lastLine)
                        {
                            dupeCount++;
                            continue;
                        }

                        //Ignore empty lines (or starting value of lastLine)
                        if (lastLine != string.Empty)
                        {
                            //Show the number of duplicate lines as well as the line itself
                            modifiedLines.Add($"{dupeCount}x {lastLine}");
                        }

                        //Reset the dupe count for next unique line
                        dupeCount = 1;
                    }
                    else
                    {
                        //Ignore empty lines (or starting value of lastLine)
                        if (lastLine != string.Empty)
                            modifiedLines.Add(lastLine);
                    }

                    //Remember last last
                    lastLine = lines[i];
                }

                //Output final collapsed logs to visual control
                if (modifiedLines.Count > 0) 
                    outputTB.Lines = modifiedLines.ToArray();
            }
        }

        string appDataPath;
        string logPath;
        GameLog combatLog;
        GameLog miningLog;

        public MainForm()
        {
            InitializeComponent();

            //Cache often reused paths (these should never change while the app is running)
            appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                .Replace("Roaming", "LocalLow");
            logPath = @$"{appDataPath}\LucidSight, Inc\CSC-Alpha\";

            combatLog = new GameLog($"{logPath}{combatLogFileName}");
            miningLog = new GameLog($"{logPath}{miningLogFileName}");

            LogPollTimer.Interval = 1000;
            LogPollTimer.Enabled = true;
        }

        #region Control Events

        private void ApplyCombatFiltersButton_Click(object sender, EventArgs e)
        {
            RefreshLogDisplay(true, false);
        }
        private void ApplyMiningFiltersButton_Click(object sender, EventArgs e)
        {
            RefreshLogDisplay(false, true);
        }
        private void LogPollTimer_Tick(object sender, EventArgs e)
        {
            RefreshLogDisplay(
                combatLog.Read(),
                miningLog.Read());
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
                MakeRegistryHex(key, "user_h2087973204"),
                MakeRegistryHex(key, "password_h1569157018")
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

        #endregion

        private void RefreshLogDisplay(bool combat = true, bool mining = true)
        {
            if(combat) combatLog.Display(
                CombatOmissionList, 
                CombatLogTB, 
                CombatCollapsedCB.Checked);

            if(mining) miningLog.Display(
                MiningOmissionList,
                MiningLogTB,
                MiningCollapsedCB.Checked);
        }
        private string MakeRegistryHex(RegistryKey key, string rkName)
        {
            var data = key.GetValue(rkName) as byte[];
            var strdata = BitConverter.ToString(data);
            return $"\"{rkName}\" = hex:{strdata.Replace("-", ",")}";
        }
    }
}