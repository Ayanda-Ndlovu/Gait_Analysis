
namespace Gait_analysis
{
    partial class Gait_Analysis_Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gait_Analysis_Application));
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenVideo = new System.Windows.Forms.ToolStripButton();
            this.UploadFile = new System.Windows.Forms.ToolStripButton();
            this.txtFile = new System.Windows.Forms.ToolStripButton();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.ResumeButton = new System.Windows.Forms.ToolStripButton();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.FowardButton = new System.Windows.Forms.ToolStripButton();
            this.SlowDownButton = new System.Windows.Forms.ToolStripButton();
            this.SaveTimeButton = new System.Windows.Forms.ToolStripButton();
            this.TxtFileClearing = new System.Windows.Forms.ToolStripButton();
            this.comboBoxVideo = new System.Windows.Forms.ToolStripComboBox();
            this.Uploaded_Files = new System.Windows.Forms.ToolStripComboBox();
            this.HelpPanel = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(1424, 637);
            this.WindowsMediaPlayer.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenVideo,
            this.UploadFile,
            this.txtFile,
            this.PlayButton,
            this.StopButton,
            this.ResumeButton,
            this.BackButton,
            this.FowardButton,
            this.SlowDownButton,
            this.SaveTimeButton,
            this.TxtFileClearing,
            this.comboBoxVideo,
            this.Uploaded_Files,
            this.HelpPanel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1424, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenVideo
            // 
            this.OpenVideo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenVideo.Image = ((System.Drawing.Image)(resources.GetObject("OpenVideo.Image")));
            this.OpenVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenVideo.Name = "OpenVideo";
            this.OpenVideo.Size = new System.Drawing.Size(106, 29);
            this.OpenVideo.Text = "Load Video";
            this.OpenVideo.Click += new System.EventHandler(this.OpenVideo_Click);
            // 
            // UploadFile
            // 
            this.UploadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UploadFile.Image = ((System.Drawing.Image)(resources.GetObject("UploadFile.Image")));
            this.UploadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(146, 29);
            this.UploadFile.Text = "Upload File/Files";
            this.UploadFile.Click += new System.EventHandler(this.UploadFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtFile.Image = ((System.Drawing.Image)(resources.GetObject("txtFile.Image")));
            this.txtFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(128, 29);
            this.txtFile.Text = "Upload_TxtFile";
            this.txtFile.Click += new System.EventHandler(this.txtFile_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 29);
            this.PlayButton.Text = "Play/Pause";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(53, 29);
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResumeButton.Image = ((System.Drawing.Image)(resources.GetObject("ResumeButton.Image")));
            this.ResumeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(78, 29);
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.Click += new System.EventHandler(this.Resume_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 29);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FowardButton
            // 
            this.FowardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FowardButton.Image = ((System.Drawing.Image)(resources.GetObject("FowardButton.Image")));
            this.FowardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FowardButton.Name = "FowardButton";
            this.FowardButton.Size = new System.Drawing.Size(81, 29);
            this.FowardButton.Text = "Forward";
            this.FowardButton.Click += new System.EventHandler(this.FowardButton_Click);
            // 
            // SlowDownButton
            // 
            this.SlowDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SlowDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SlowDownButton.Image")));
            this.SlowDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SlowDownButton.Name = "SlowDownButton";
            this.SlowDownButton.Size = new System.Drawing.Size(106, 29);
            this.SlowDownButton.Text = "Slow Down";
            this.SlowDownButton.Click += new System.EventHandler(this.SlowDownButton_Click_1);
            // 
            // SaveTimeButton
            // 
            this.SaveTimeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveTimeButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveTimeButton.Image")));
            this.SaveTimeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTimeButton.Name = "SaveTimeButton";
            this.SaveTimeButton.Size = new System.Drawing.Size(96, 29);
            this.SaveTimeButton.Text = "Save Time";
            this.SaveTimeButton.Click += new System.EventHandler(this.SaveTimeButton_Click);
            // 
            // TxtFileClearing
            // 
            this.TxtFileClearing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TxtFileClearing.Image = ((System.Drawing.Image)(resources.GetObject("TxtFileClearing.Image")));
            this.TxtFileClearing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TxtFileClearing.Name = "TxtFileClearing";
            this.TxtFileClearing.Size = new System.Drawing.Size(121, 29);
            this.TxtFileClearing.Text = "Clear Text File";
            this.TxtFileClearing.Click += new System.EventHandler(this.TxtFileClearing_Click);
            // 
            // comboBoxVideo
            // 
            this.comboBoxVideo.Name = "comboBoxVideo";
            this.comboBoxVideo.Size = new System.Drawing.Size(121, 34);
            this.comboBoxVideo.Text = "Videos";
            // 
            // Uploaded_Files
            // 
            this.Uploaded_Files.Name = "Uploaded_Files";
            this.Uploaded_Files.Size = new System.Drawing.Size(121, 34);
            this.Uploaded_Files.Text = "Uploaded_Files";
            // 
            // HelpPanel
            // 
            this.HelpPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpPanel.Image = ((System.Drawing.Image)(resources.GetObject("HelpPanel.Image")));
            this.HelpPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(53, 29);
            this.HelpPanel.Text = "Help";
            this.HelpPanel.Click += new System.EventHandler(this.HelpPanel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Gait_Analysis_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 637);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gait_Analysis_Application";
            this.Text = "Gait_Analysis_Application";
            this.Load += new System.EventHandler(this.Gait_Analysis_Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenVideo;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton FowardButton;
        private System.Windows.Forms.ToolStripButton SaveTimeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton SlowDownButton;
        private System.Windows.Forms.ToolStripButton ResumeButton;
        private System.Windows.Forms.ToolStripComboBox comboBoxVideo;
        private System.Windows.Forms.ToolStripButton UploadFile;
        private System.Windows.Forms.ToolStripButton TxtFileClearing;
        private System.Windows.Forms.ToolStripComboBox Uploaded_Files;
        private System.Windows.Forms.ToolStripButton HelpPanel;
        private System.Windows.Forms.ToolStripButton txtFile;
    }
}

