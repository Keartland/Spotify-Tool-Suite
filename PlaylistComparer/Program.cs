using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "get";
            while (token == "get" || token.Length < 40)
            {
                Console.Write("enter token playlist (type get to get one): ");
                token = Console.ReadLine();
                if (token.ToLower() == "get")
                {
                    Spotify.getToken();
                }
            }
            Console.Write("enter first playlist: ");
            string fplaylist = Console.ReadLine();
            Console.Write("enter second playlist: ");
            string splaylist = Console.ReadLine();
            Console.WriteLine("Getting the first playlist");
            Dictionary<string, List<string>> playlist1 = Spotify.requestSpotifyForPlaylist(fplaylist, token);
            Console.WriteLine("Getting the second playlist");
            Dictionary<string, List<string>> playlist2 = Spotify.requestSpotifyForPlaylist(splaylist, token);
            Console.WriteLine();
            Console.WriteLine("Comparing differences in the playlists: ");
            Console.WriteLine();
            List<string> ulist = playlist1.Keys.ToList().Union(playlist2.Keys.ToList()).ToList();
            List<string> olist = new List<string>();
            foreach (string artist in ulist)
            {
                if (playlist1.Keys.Contains(artist) && playlist2.Keys.Contains(artist))
                {
                    foreach (string title in playlist1[artist].Except(playlist2[artist]))
                    {
                        olist.Add(artist + " - " + title);
                    }
                }
                else if(playlist1.Keys.Contains(artist))
                {
                    foreach (string title in playlist1[artist])
                    {
                        olist.Add(artist + " - " + title);
                    }
                }
                else if (playlist2.Keys.Contains(artist))
                {
                    foreach (string title in playlist2[artist])
                    {
                        olist.Add(artist + " - " + title);
                    }
                }
            }
            Console.WriteLine("Amount of different songs: " + olist.Count + "\n");
            olist.Sort();
            Console.WriteLine(string.Join("\n",olist));
            Console.ReadKey();
        }
    }
}
