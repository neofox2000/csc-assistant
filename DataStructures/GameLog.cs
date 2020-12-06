using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CSC_Assistant
{
    struct GameLog
    {
        const int archiveSizeLimit = 16777216;
        const int lineLimit = 9999;
        DateTime lastEntry;
        string path;
        string tempPath;
        string archivePath;
        string[] lines;

        public GameLog(string path, string tempPath, string archivePath)
        {
            lastEntry = DateTime.MinValue;
            this.path = path;
            this.tempPath = tempPath;
            this.archivePath = archivePath;
            lines = null;
        }
        public bool Read()
        {
            bool skipLastEntryStamp = false;

            //Skip initial validation if a temp file is present (it got stuck or something)
            if (!File.Exists(tempPath))
            {
                //Bail if no log file is present
                if (!File.Exists(path)) return false;

                //Check logfile for changes
                var fileDT = File.GetLastWriteTime(path);

                //Bail if file hasn't been written since last read
                if (fileDT < lastEntry) return false;
            }
            else
            {
                skipLastEntryStamp = true;
            }

            //Attempt to read entire log file - bail on error
            try
            {
                //Skip this step if a temp file is already present
                if (!File.Exists(tempPath))
                    //Move log to allow more to be written - ...
                    //...CSC has a log size limit at which point it...
                    //...simply stops writing logs to the file
                    File.Move(path, tempPath);

                var newLines = File.ReadAllLines(tempPath);
                int oldLinesLength = lines == null ? 0 : lines.Length;

                //Clear lines if over limit
                if (oldLinesLength >= lineLimit) lines = new string[0];

                Array.Resize(ref lines, oldLinesLength + newLines.Length + 1);

                //Timestamp new data
                lines[oldLinesLength] = DateTime.Now.ToString();

                //lines = File.ReadAllLines(tempPath);
                //Append new lines to the end of previous lines
                Array.Copy(newLines, 0, lines, oldLinesLength + 1, newLines.Length);

                if (!skipLastEntryStamp)
                    lastEntry = DateTime.Now;

                //Delete archive file if over limit
                if (File.Exists(archivePath) && (new FileInfo(archivePath).Length > archiveSizeLimit))
                    File.Delete(archivePath);

                //Append log to archive
                File.AppendAllLines(archivePath, lines);

                //Delete temp
                File.Delete(tempPath);
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
}