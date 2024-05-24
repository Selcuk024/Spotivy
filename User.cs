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
        public List<Playlist> Playlists { get; set; }

        public string Username;

        Playlist playlist = new Playlist();

        public List<Playlist> UserPlaylists = new List<Playlist>();
        

        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
            Console.WriteLine($"Playlist '{playlist.Name}' added to user '{Username}'.");
        }
        public void 

    }
    }
}
