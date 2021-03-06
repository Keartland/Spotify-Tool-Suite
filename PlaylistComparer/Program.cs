﻿using System;
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
            comparePlaylists(fplaylist, splaylist, token);
            Console.ReadKey();
        }
        static void comparePlaylists(string fplaylist, string splaylist, string token)
        {
            Console.WriteLine("Getting the first playlist");
            Dictionary<string, List<string>> playlist1 = Spotify.requestSpotifyForPlaylist(fplaylist, token);
            Console.WriteLine("Getting the second playlist");
            Dictionary<string, List<string>> playlist2 = Spotify.requestSpotifyForPlaylist(splaylist, token);
            Console.WriteLine();
            Console.WriteLine("Comparing differences in the playlists: ");
            Console.WriteLine();
            List<string> ulist = playlist1.Keys.ToList().Union(playlist2.Keys.ToList()).ToList();
            Dictionary<string,List<string>> olist = new Dictionary<string, List<string>>();
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
            Console.WriteLine("Amount of different songs: " + olist.Count + "\n");
            foreach(KeyValuePair<string,List<string>> val in olist)
            {
                Console.WriteLine(val.Key + " - " + string.Join(", ", val.Value.Distinct()));
            }
        }
    }
}
