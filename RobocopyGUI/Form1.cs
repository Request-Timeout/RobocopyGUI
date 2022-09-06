using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RobocopyGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string fileName = "cmd.exe";
            string arguments = "";

            var processStartInfo = new ProcessStartInfo(fileName, arguments);
            processStartInfo.UseShellExecute = false;
            processStartInfo.ErrorDialog = false;
            processStartInfo.CreateNoWindow = false;

            InitializeComponent();
        }

        private void sourceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string strOptions = "";
            bool adminNeeded = false;
            if (sourceText.Text == "")
            {
                MessageBox.Show("ERROR - Source field is empty.");
            }
            else if (destinationText.Text == "")
                {
                MessageBox.Show("ERROR - Destination field is empty.");
            } else
            {
                if (subDirComboBox.SelectedItem != null)
                {
                    if (strOptions == "")
                    {
                        strOptions = strOptions + dictOptions[subDirComboBox.SelectedItem.ToString()];
                    }
                    else
                    {
                        strOptions = strOptions + ' ' + dictOptions[subDirComboBox.SelectedItem.ToString()];
                    }
                }
                if (backupModeComboBox.SelectedItem != null)
                {
                    if (
                        backupModeComboBox.SelectedItem.ToString() == "/ZB :: use restartable mode; if access denied use Backup mode." ||
                        backupModeComboBox.SelectedItem.ToString() == "/B :: copy files in Backup mode."
                        )
                    {
                        adminNeeded = true;
                    }

                    if (strOptions == "")
                    {
                        strOptions = strOptions + dictOptions[subDirComboBox.SelectedItem.ToString()];
                    }
                    else
                    {
                        strOptions = strOptions + ' ' + dictOptions[subDirComboBox.SelectedItem.ToString()];
                    }
                }

                
                if (optionsCheckedListBox.CheckedItems.Count > 0)
                {
                    foreach (var item in optionsCheckedListBox.CheckedItems)
                    {
                        if (strOptions == "")
                        {
                            //strOptions = strOptions + item.ToString().Substring(0, 2);
                            strOptions = strOptions + dictOptions[item.ToString()];
                        } else
                        {
                            //strOptions = strOptions + ' ' + item.ToString().Substring(0, 2);
                            strOptions = strOptions + ' ' + dictOptions[item.ToString()];
                        }            
                    }

                }

                //string strCmdText;
                ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
                if (adminNeeded)
                {
                    startInfo.Verb = "runas";
                }

                //startInfo.Arguments = "/C robocopy.exe /ZB /E C:\\SOURCE C:\\DESTINATION";
                //sourceText.Text = "C:\\SOURCE";
                //destinationText.Text = "C:\\DESTINATION";

                if (strOptions == "")
                {
                    startInfo.Arguments = $"/C robocopy.exe {sourceText.Text} {destinationText.Text}";
                } else
                {
                    startInfo.Arguments = $"/C robocopy.exe {strOptions} {sourceText.Text} {destinationText.Text}";
                }
                
                //strCmdText = $"/C robocopy.exe {sourceText.Text} {destinationText.Text}";
                //strCmdText = "/C robocopy.exe 'C:\\SOURCE' 'C:\\DESTINATION'";
                //strCmdText = "pause";
                Process.Start(startInfo);
            }
        }

        /*
        void optionsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //textBox1.Text = optionsListBox.CheckedItems.Count.ToString();
            foreach (var item in optionsListBox.CheckedItems)
            {
                //textBox1.Text = item.ToString();
                MessageBox.Show(item.ToString());
            }
            this.BeginInvoke((MethodInvoker)(
                () => Console.WriteLine(optionsListBox.SelectedItems.Count)));
        }
        */

        /*
        private void optionsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in optionsListBox.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }
            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add(optionsListBox.Items[e.Index].ToString());
            }
            else
            {
                checkedItems.Remove(optionsListBox.Items[e.Index].ToString());
            }
        }
        */

        Dictionary<string, string> dictOptions = new Dictionary<string, string>()
        {
            { "/S :: copy Subdirectories, but not empty ones.", "/S" },
            { "/E :: copy subdirectories, including Empty ones.", "/E" },
            { "/Z :: copy files in restartable mode.", "/Z" },
            { "/B :: copy files in Backup mode.", "/B" },
            { "/ZB :: use restartable mode; if access denied use Backup mode.", "/ZB" },
            { "/J :: copy using unbuffered I/O (recommended for large files).", "/J" },
            { "/EFSRAW :: copy all encrypted files in EFS RAW mode.", "/EFSRAW" },
            { "/SEC :: copy files with SECurity (equivalent to /COPY:DATS).", "/SEC" },
            { "/COPYALL :: COPY ALL file info (equivalent to /COPY:DATSOU).", "/COPYALL" },
            { "/NOCOPY :: COPY NO file info (useful with /PURGE).", "/NOCOPY" },
            { "/SECFIX :: FIX file SECurity on all files, even skipped files.", "/SECFIX" },
            { "/TIMFIX :: FIX file TIMes on all files, even skipped files.", "/TIMFIX" },
            { "/PURGE :: delete dest files/dirs that no longer exist in source.", "/PURGE" },
            { "/MIR :: MIRror a directory tree (equivalent to /E plus /PURGE).", "/MIR" },
            { "/MOV :: MOVe files (delete from source after copying).", "/MOV" },
            { "/MOVE :: MOVE files AND dirs (delete from source after copying).", "/MOVE" },
            { "/CREATE :: CREATE directory tree and zero-length files only.", "/CREATE" },
            { "/FAT :: create destination files using 8.3 FAT file names only.", "/FAT" },
            { "/256 :: turn off very long path (> 256 characters) support.", "/256" },
            { "/SJ :: copy Junctions as junctions instead of as the junction targets.", "/SJ" },
            { "/SL :: copy Symbolic Links as links instead of as the link targets.", "/SL" },
            { "/NODCOPY :: COPY NO directory info (by default /DCOPY:DA is done).", "/NODCOPY" },
            { "/NOOFFLOAD :: copy files without using the Windows Copy Offload mechanism.", "/NOOFFLOAD" },
            { "/COMPRESS :: Request network compression during file transfer, if applicable.", "/COMPRESS" },
            { "/A : Copy only files with the Archive attribute set.", "/A" },
            { "/M : like /A, but remove Archive attribute from source files.", "/M" },
            { "/XC :: eXclude Changed files.", "/XC" },
            { "/XN :: eXclude Newer files.", "/XN" },
            { "/XO :: eXclude Older files.", "/XO" },
            { "/XX :: eXclude eXtra files and directories.", "/XX" },
            { "/XL :: eXclude Lonely files and directories.", "/XL" },
            { "/IS :: Include Same files.", "/IS" },
            { "/IT :: Include Tweaked files.", "/IT" },
            { "/FFT :: assume FAT File Times (2-second granularity).", "/FFT" },
            { "/DST :: compensate for one-hour DST time differences.", "/DST" },
            { "/XJ :: eXclude symbolic links (for both files and directories) and Junction points.", "/XJ" },
            { "/XJD :: eXclude symbolic links for Directories and Junction points.", "/XJD" },
            { "/XJF :: eXclude symbolic links for Files.", "/XJF" },
            { "/IM :: Include Modified files (differing change times).", "/IM" },
            { "/TBD :: Wait for sharenames To Be Defined (retry error 67).", "/TBD" },
            { "/LFSM :: Operate in low free space mode, enabling copy pause and resume (see Remarks).", "/LFSM" }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void browseSourceButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceFolderDialog = new FolderBrowserDialog();
            sourceFolderDialog.ShowDialog();
            sourceText.Text = sourceFolderDialog.SelectedPath;
            Console.ReadLine();
        }

        private void browseDestButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destFolderDialog = new FolderBrowserDialog();
            destFolderDialog.ShowDialog();
            destinationText.Text = destFolderDialog.SelectedPath;
        }
    }
}
