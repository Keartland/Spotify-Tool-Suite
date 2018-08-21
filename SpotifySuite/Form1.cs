using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifySuite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            startScreen1.BringToFront();
        }

        private void playlistComparer_Click(object sender, EventArgs e)
        {
            playlistComparer1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            startScreen1.BringToFront();
        }

        private void artistCounter_Click(object sender, EventArgs e)
        {
            artistCounter1.BringToFront();
        }
    }
}
