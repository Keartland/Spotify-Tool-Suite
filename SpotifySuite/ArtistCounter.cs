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
    public partial class ArtistCounter : UserControl
    {
        public ArtistCounter()
        {
            InitializeComponent();
        }

        private void GetToken_Click(object sender, EventArgs e)
        {
            Spotify.getToken();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "";
            Dictionary<string, int> playlistScoreboard = Spotify.countArtists(playlist.Text, token.Text);
            var sortedDict = from entry in playlistScoreboard orderby entry.Value descending select entry;
            int pos = 0;
            chart1.Titles["Title1"].Visible = true;
            foreach (var val in sortedDict)
            {
                pos++;
                output.Text += pos + ") " + val.Key + ", " + val.Value + "\n";
                if (pos <= 10)
                {
                    chart1.Series["Series1"].Points.AddXY(val.Key, val.Value);
                } 
            }
        }
    }
}
