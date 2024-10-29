using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gait_analysis
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Gait_Analysis_Application form1 = new Gait_Analysis_Application(); 
            form1.Show();           
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
