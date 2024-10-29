using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Gait_analysis
{
    public partial class Gait_Analysis_Application : Form
    {
        public Gait_Analysis_Application()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        int ButtonClickcount = 0;
        private double SavedTime = 0;
        string FileName;
        private List<string> videoFiles = new List<string>();
        private List<string> FilePaths = new List<string>();
        private double accelStartTimestamp;
        private double difference;

        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        //----------------------------button to open multiple videos add them to combo box and also add them to list of videos--------------
        private void OpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select Video Files";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoFiles.AddRange(openFileDialog.FileNames);
                comboBoxVideo.Items.Clear();
                foreach (string videoFile in videoFiles)
                {
                    comboBoxVideo.Items.Add(System.IO.Path.GetFileName(videoFile));
                }

                if (comboBoxVideo.Items.Count > 0)
                {
                    comboBoxVideo.SelectedIndex = 0;
                }
                WindowsMediaPlayer.settings.autoStart = false;
                WindowsMediaPlayer.URL = videoFiles[0];
                MessageBox.Show($"{videoFiles.Count} video(s) loaded successfully.", "Videos Loaded");
            }
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {

            ButtonClickcount++;
            if (ButtonClickcount == 1)
            {
                if (videoFiles.Count == 0 || FilePaths.Count == 0 || FileName == null)
                {
                    MessageBox.Show("Please load Video, Excel File, and Txt File before proceeding.", "Missing Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ButtonClickcount--;
                    return;
                }
                else
                {
                    EnablePlaybackButtons();
                    WindowsMediaPlayer.Ctlcontrols.play();
                    stopwatch.Reset();
                    stopwatch.Start();
                }
            }
            else if (ButtonClickcount == 2)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                ButtonClickcount = 0;
            }
        }


        private void EnablePlaybackButtons()
        {
            StopButton.Enabled = true;
            ResumeButton.Enabled = true;
            BackButton.Enabled = true;
            FowardButton.Enabled = true;
            SlowDownButton.Enabled = true;
            SaveTimeButton.Enabled = true;
            StopButton.Enabled = true;
        }

        private void SynchronizeHeelStrikeWithVideo(double videoTime)
        {
            try
            {
                double timeDifferenceMs = difference;
                double timeDifferenceSec = timeDifferenceMs / 1000.0;
                MessageBox.Show($"Time Difference (sec): {timeDifferenceSec}");
                double newVideoTime = 0;
                if (timeDifferenceMs > 0)
                {
                    newVideoTime = videoTime + timeDifferenceSec;
                }
                else
                {
                    newVideoTime = videoTime - timeDifferenceSec;
                }
                WindowsMediaPlayer.Ctlcontrols.currentPosition = newVideoTime;
                MessageBox.Show($"The video has been adjusted. New video time: {newVideoTime} seconds.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during synchronization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void StopButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {

            stopwatch.Stop();
            WindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.fastReverse();
        }

        private void FowardButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.fastForward();
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.currentPosition = SavedTime;
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        //-------------------------------button to save the time and compare it with the time in the file----------------------
        private void SaveTimeButton_Click(object sender, EventArgs e)
        {
            double heeltime = WindowsMediaPlayer.Ctlcontrols.currentPosition;
            string message = "You selected a heel-strike time of " + heeltime.ToString() + " seconds. Would you like to sync this with the accelerometer data?";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.None;
            DialogResult result = MessageBox.Show(message,heeltime.ToString() ,button, icon);
            ExcelFile excelFile = new ExcelFile(FilePaths[comboBoxVideo.SelectedIndex], 1);
            double closestAccelTime = excelFile.ReadCell(heeltime);

            if(result == DialogResult.Yes)
            {
                if (closestAccelTime == 0)
                {
                    MessageBox.Show("No accelerometer data could be found that matches the selected heel-strike time. Please try again.");
                }
                else
                {
                    accelStartTimestamp = excelFile.GetStartTimestamp();
                    string accelData = excelFile.GetCorrespondingData(closestAccelTime);
                    difference = excelFile.getdifference(heeltime);
                    SynchronizeHeelStrikeWithVideo(heeltime);
                    MessageBox.Show($"Your Saved Time is : {heeltime}\nClosest accelerometer time: {closestAccelTime}\nData at this time: {accelData}", "Synchronization Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    writeinFile(comboBoxVideo.SelectedItem.ToString(), heeltime, closestAccelTime.ToString() , accelData);

                }
            }
        }

        public void writeinFile(String VideoName,double mytime, string resultTime, string closestTime)
        {
            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(mytime + " | "+ VideoName + " | "+ closestTime +" | "+ resultTime);
                MessageBox.Show("Your Time Has been Saved in the Text File");
            }
        }

        //------------------------------button to upload file and it to a list of files-------------------
        private void UploadFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Files in the order of the videos such that video 1 goes with File 1");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|Excel Files|*.xlsx";
            openFileDialog.Title = "Select Accelerometer Data File";
            Uploaded_Files.Items.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                FilePaths.Add(filePath);
                Uploaded_Files.Items.Add(System.IO.Path.GetFileName(filePath));
                MessageBox.Show("The accelerometer data file has been loaded successfully.");
                ExcelFile excelFile = new ExcelFile(FilePaths[comboBoxVideo.SelectedIndex], 1);


            }
        }

        //---------------------------------button to slow down the video-------------------------------------
        private void SlowDownButton_Click_1(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.rate = 0.01;
        }


        private void TxtFileClearing_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ? ";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.None;
            DialogResult result = MessageBox.Show(message,null, button, icon);
            if (result == DialogResult.Yes)
            {
                using (StreamWriter writer = new StreamWriter(FileName, false))
                {}
                MessageBox.Show("Text File Cleared");
                using (StreamWriter writer = new StreamWriter(FileName, false))
                {
                    writer.WriteLine("The Captured Time | Name of Video   | The Closest Time  | The Corresponding Accelerometer Data");
                }

            }
        }

        private void HelpPanel_Click(object sender, EventArgs e)
        {
            Help form1 = new Help();
            form1.Show();
            //this.Close();
        }

        private void Gait_Analysis_Application_Load(object sender, EventArgs e)
        {
            StopButton.Enabled = false;
            ResumeButton.Enabled = false;
            BackButton.Enabled = false;
            FowardButton.Enabled = false;
            SlowDownButton.Enabled = false;
            SaveTimeButton.Enabled = false;
            StopButton.Enabled = false;
        }

        private void txtFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
            }

        }
    }
}
