
namespace Gait_analysis
{
    partial class Help
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
            this.Description = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.FormattingEnabled = true;
            this.Description.HorizontalScrollbar = true;
            this.Description.ItemHeight = 20;
            this.Description.Items.AddRange(new object[] {
            "This program allows you to analyze gait by synchronizing video footage of walking" +
                " or running with accelerometer data.",
            "it helps to identify and mark the time when the heel strikes the ground in the vi" +
                "deo ",
            "and syncs this time with corresponding accelerometer data for further analysis.",
            "",
            "To run this program, your system needs the following:",
            "- Windows operating system (Windows 7 or later)",
            "- .NET Framework 4.5 or higher",
            "- Minimum of 4GB RAM",
            "- A video file and an accelerometer data file in supported formats (MP4, XLSX).\"",
            "",
            "",
            " Step-by-step instructions on how to load one or multiple video files.",
            "1. Click the \"Load Video\"button to open a file dialog.",
            "2. Select the video files you want to analyze (supports MP4, AVI, etc.).",
            "3. Once loaded, you can preview the video in the player window.",
            "4. Use the controls to play, pause, and navigate through the video.",
            "   ",
            "",
            "How to load the accelerometer data (XLSX) file that contains the time-stamped acc" +
                "elerometer readings.",
            "1. Click the \"Upload File/Files\" button to open a file dialog.",
            "2. Select the Excel file that contains the accelerometer data.",
            "3. Ensure the file is in the correct format (first column should have timestamps," +
                " ",
            "and subsequent columns should have accelerometer readings).",
            "4. After uploading, the data is automatically loaded into the system for syncing " +
                "with the video.",
            "Here are step-by-step instructions on how to load one or multiple text files into" +
                " your application:",
            "",
            "Step-by-step Instructions on How to Load Text File",
            "1. Click the \"Upload Text File\" button to open a file dialog.",
            "2. Select the text files you want to load (supports .txt format).",
            "3. Once the files are loaded, you will see the filenames listed in the applicatio" +
                "n.",
            "4. Use the provided controls to access and save the contents or specific data poi" +
                "nts from the text files.",
            "",
            "",
            "Feel free to modify the wording to better fit your application\'s style! If you ne" +
                "ed anything else, let me know.",
            "nstructions on how to mark the moment the heel contacts the ground in the video.",
            "1. Play the video and pause it when the heel first strikes the ground.",
            "2. Use the \"Save Time\" button to record this time.",
            "3. The time will be saved and synced with the corresponding accelerometer data.",
            "4. You can mark multiple heel-strike times by repeating the process.",
            "",
            "How the program matches the heel-strike time with the accelerometer data and how " +
                "to ensure accuracy.?",
            "1. Once the heel-strike time is marked, the program automatically finds the close" +
                "st timestamp from the accelerometer data.",
            "2. For greater accuracy, the program may interpolate between two timestamps if th" +
                "e exact match is not found.",
            "3. The corresponding accelerometer values for the heel-strike time will be displa" +
                "yed on the interface.",
            "",
            "",
            "Instructions for visualizing the accelerometer data as a chart within the program" +
                ".",
            "1. Once you load the accelerometer data, the program will plot it as a line chart" +
                ".",
            "2. As you play the video, the chart cursor will move along the timeline to show t" +
                "he accelerometer data.",
            "3. You can manually browse through the accelerometer data using the chart.",
            "",
            "",
            "Instructions for saving the heel-strike time and accelerometer data for later ana" +
                "lysis.",
            "1. After marking the heel-strike time, click the \"Save\" button.",
            "2. The program will save the video timestamp and the corresponding accelerometer " +
                "data to an output file (CSV, Excel).",
            "3. You can specify the file name and location where you want to save the results." +
                "",
            "",
            "",
            "Common issues users might encounter and how to resolve them.",
            "-Problem: \"No accelerometer data found for the selected time.\"",
            "- Solution: Ensure the accelerometer data file is in the correct format and the t" +
                "imestamps align with the video time.",
            "-Problem: \"Video or file format not supported.\"",
            "- Solution: Make sure the video is in MP4, AVI format and the accelerometer file " +
                "is in XLSX format.",
            "",
            "",
            "A quick reference to the buttons and features of the program.",
            "- Load Video: Opens a dialog to load video files.",
            "-Load Accelerometer Data**: Opens a dialog to load the accelerometer data file.",
            "- Play/Pause: Starts or pauses the video playback.",
            "-Save Time: Saves the current video timestamp as the heel-strike time.",
            "-Save Data: Saves the marked heel-strike time and the corresponding accelerometer" +
                " data to a file.",
            "- Chart: Displays a plot of the accelerometer data.",
            "",
            "",
            "Tips on how to ensure the best results when using the program.",
            " - For the best synchronization, make sure the video and accelerometer data are r" +
                "ecorded at the same time and use the same time scale.",
            " - If the video frame rate is too high or low, consider adjusting the playback sp" +
                "eed to mark the heel-strike time more accurately.",
            " - Ensure the accelerometer data file includes clear, continuous timestamps for b" +
                "etter interpolation.",
            "",
            "",
            "information about the program version, the development team, and contact informat" +
                "ion for support.",
            "     > \"Version: 1.0.0",
            "     > Developed by Ayanda Ndlovu.",
            "     > For support, please contact ayandan881@gmail.com\"",
            "",
            "",
            "How to safely close the program.",
            "     > \"Click the **\'Exit\'** button or close the window using the \'X\' at the top-" +
                "right corner to safely exit the program.\""});
            this.Description.Location = new System.Drawing.Point(0, 0);
            this.Description.Name = "Description";
            this.Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Description.ScrollAlwaysVisible = true;
            this.Description.Size = new System.Drawing.Size(985, 650);
            this.Description.TabIndex = 1;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 650);
            this.Controls.Add(this.Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Description;
    }
}