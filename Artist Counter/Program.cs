using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistCounter
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
            string playlist = Console.ReadLine();
            getPlaylist(playlist, token);
        }

        static void getPlaylist(string playlist, string token)
        {
            Console.WriteLine("Getting the playlist and analysing: ");
            Dictionary<string, int> playlistScoreboard = Spotify.requestSpotifyForPlaylistArtistCount(playlist, token);
            var sortedDict = from entry in playlistScoreboard orderby entry.Value descending select entry;
            int pos = 0;
            foreach (var val in sortedDict)
            {
                pos++;
                Console.WriteLine(pos + ") " + val.Key + ", " + val.Value);
                if (pos % 15 == 0)
                {
                    Console.WriteLine("press any key to get the next 15 or press e to exit...");
                    if (Console.ReadKey().KeyChar == 'e')
                    {
                        return;
                    }
                }
            }
        }
    }
}
