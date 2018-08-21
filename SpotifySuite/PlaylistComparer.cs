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
    public partial class PlaylistComparer : UserControl
    {
        public PlaylistComparer()
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
            Dictionary<string, List<string>> playlist1 = Spotify.comparePlaylists(fplaylist.Text, token.Text);
            Dictionary<string, List<string>> playlist2 = Spotify.comparePlaylists(splaylist.Text, token.Text);
            List<string> ulist = playlist1.Keys.ToList().Union(playlist2.Keys.ToList()).ToList();
            Dictionary<string, List<string>> olist = new Dictionary<string, List<string>>();
            foreach (string artist in ulist)
            {
                if (playlist1.Keys.Contains(artist) && playlist2.Keys.Contains(artist))
                {
                    foreach (string title in playlist1[artist].Except(playlist2[artist]))
                    {
                        if (!olist.Keys.Contains(title))
                        {
                            olist[title] = new List<string>();
                        }
                        olist[title].Add(artist);
                    }
                }
                else if (playlist1.Keys.Contains(artist))
                {
                    foreach (string title in playlist1[artist])
                    {
                        if (!olist.Keys.Contains(title))
                        {
                            olist[title] = new List<string>();
                        }
                        olist[title].Add(artist);
                    }
                }
                else if (playlist2.Keys.Contains(artist))
                {
                    foreach (string title in playlist2[artist])
                    {
                        if (!olist.Keys.Contains(title))
                        {
                            olist[title] = new List<string>();
                        }
                        olist[title].Add(artist);
                    }
                }
            }
            difSongs.Text = olist.Count.ToString();
            foreach (KeyValuePair<string, List<string>> val in olist)
            {
                output.Text += val.Key + " - " + string.Join(", ", val.Value.Distinct()) + "\n";
            }
        }
    }
}
