using CSC_Assistant.Common.DataStructures;
using CSC_Assistant.Client.Data;
using System;
using System.Windows.Forms;

namespace CSC_Assistant.Client.Forms
{
    public partial class LogViewerForm : Form
    {
        const string combatLogFileName = "CSC_Game_Logs.txt";
        const string miningLogFileName = "CSC_Mining_Logs.txt";

        string logPath;
        GameLog combatLog;
        GameLog miningLog;

        public LogViewerForm()
        {
            InitializeComponent();

            //Cache often reused paths (these should never change while the app is running)
            logPath = @$"{Program.appDataPathLocalLow}\LucidSight, Inc\CSC-Alpha\";
            var appPath = Program.outputPath;

            combatLog = new GameLog(
                $"{logPath}{combatLogFileName}",
                $"{appPath}\\{combatLogFileName}",
                $"{appPath}\\combatArchive.log");
            miningLog = new GameLog(
                $"{logPath}{miningLogFileName}",
                $"{appPath}\\{miningLogFileName}",
                $"{appPath}\\miningArchive.log");

            LogPollTimer.Interval = 1000;
            LogPollTimer.Enabled = true;
        }

        private void ApplyCombatFiltersButton_Click(object sender, EventArgs e)
        {
            RefreshLogDisplay(true, false);
        }

        private void MiningRefreshViewButton_Click(object sender, EventArgs e)
        {
            RefreshLogDisplay(false, true);
        }

        private void LogPollTimer_Tick(object sender, EventArgs e)
        {
            RefreshLogDisplay(
                combatLog.Read(),
                miningLog.Read());
        }

        private void RefreshLogDisplay(bool combat = true, bool mining = true)
        {
            if (combat) combatLog.Display(
                 CombatOmissionList,
                 CombatLogTB,
                 CombatCollapsedCB.Checked);

            if (mining) miningLog.Display(
                 MiningOmissionList,
                 MiningLogTB,
                 MiningCollapsedCB.Checked);
        }

        private void LogViewerForm_Shown(object sender, EventArgs e)
        {
            Dock = DockStyle.Bottom;
        }
    }
}