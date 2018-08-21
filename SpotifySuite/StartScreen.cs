using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifySuite
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        string url = "http://keart.land";
        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
