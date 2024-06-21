using Spotivy.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{

    public class User
    {
        public string Username { get; set; }


        public List<Playlist> Playlists = new List<Playlist> { };

        public User(string username)
        {
            Username = username;
            Playlists = new List<Playlist>();
        }


        // voeg nieuwe playlist
        public void createPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
            Console.WriteLine($"Playlist '{playlist.Name}' added to user '{Username}'.");
        }


        // krijg de lijst van de playlists van de user
        public List<Playlist> GetPlaylists()
        {
            return Playlists;
        }
    }

}
}
