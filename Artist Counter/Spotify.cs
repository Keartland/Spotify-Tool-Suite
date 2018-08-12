using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ArtistCounter
{
    class Spotify
    {
        public static void getToken()
        {
            string url = "https://accounts.spotify.com/en/authorize?response_type=token&redirect_uri=http:%2F%2Fkeart.land%2F&client_id=68c8ced90f6048b78c7f607da558cf46";
            System.Diagnostics.Process.Start(url);
        }
        public static string requestSpotifyForPlaylist(string playlistURL, string fields, string token)
        {
            string userID;
            string playlistID;

            string playurl = playlistURL.Split('?')[0];
            if (playurl.Split('/').Length > 3)
            {
                playlistID = playurl.Split('/').Last();
                userID = playurl.Split('/')[4];
            }
            else
            {
                return null;
            }
            string url = "https://api.spotify.com/v1/users/" + userID + "/playlists/" + playlistID + "/tracks?market=ES&fields=" + fields;
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create(url);
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Headers["Authorization"] = "Bearer " + token;
            WebResponse response = http.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string content = sr.ReadToEnd();
            return content;
        }
        public static int amountOfSongs(string playlistURL, string token)
        {
            string content = requestSpotifyForPlaylist(playlistURL, "total", token);
            JavaScriptSerializer jsonizer = new JavaScriptSerializer();
            Dictionary<string, object> json = (Dictionary<string, object>)jsonizer.DeserializeObject(content);
            try
            {
                return int.Parse(json["total"].ToString());
            }
            catch
            {
                return -1;
            }
        }
        public static Dictionary<string, int> requestSpotifyForPlaylist(string playlistURL, string token)
        {
            Dictionary<string, int> Playlist = new Dictionary<string, int>();
            int amountOfSong = amountOfSongs(playlistURL, token);
            string content;
            JavaScriptSerializer json;
            Playlist playlst;
            for (int i = 0; i < amountOfSong; i += 100)
            {
                content = requestSpotifyForPlaylist(playlistURL, "items(track(name % 2Cartists))&offset=" + i.ToString(), token);
                json = new JavaScriptSerializer();
                playlst = json.Deserialize<Playlist>(content);
                foreach (Song song in playlst.items)
                {
                    foreach (Artist art in song.track.artists)
                    {
                        string artist = art.name;
                        string songname = song.track.name;
                        if (!Playlist.Keys.Contains(artist))
                        {
                            Playlist[artist] = 0;
                        }
                        Playlist[artist]++;
                    }
                }
            }
            int extra = amountOfSong % 100;
            content = requestSpotifyForPlaylist(playlistURL, "items(track(name % 2Cartists))&offset=" + (amountOfSong - extra) + "&limit=" + extra, token);
            json = new JavaScriptSerializer();
            playlst = json.Deserialize<Playlist>(content);
            foreach (Song song in playlst.items)
            {
                foreach (Artist art in song.track.artists)
                {
                    string artist = art.name;
                    string songname = song.track.name;
                    if (!Playlist.Keys.Contains(artist))
                    {
                        Playlist[artist] = 0;
                    }
                    Playlist[artist]++;
            }
            }
            return Playlist;
        }
    }
    public class Playlist
    {
        public Song[] items { get; set; }
    }
    public class Song
    {
        public Track track { get; set; }
    }
    public class Track
    {
        public Artist[] artists { get; set; }
        public string name { get; set; }
    }
    public class Artist
    {
        public string name { get; set; }
    }
}
