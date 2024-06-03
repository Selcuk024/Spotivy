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
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; set; }

        public User(int userId, string username, string email, string password)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Password = password;
            Playlists = new List<Playlist>();
        }


        // voeg nieuwe playlist
        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
            Console.WriteLine($"Playlist '{playlist.Name}' added to user '{Username}'.");
        }

        public void RemovePlaylist(string playlistName)
        {
            Playlist playlistToRemove = Playlists.Find(p => p.Name.Equals(playlistName, StringComparison.OrdinalIgnoreCase));
            if (playlistToRemove != null)
            {
                Playlists.Remove(playlistToRemove);
                Console.WriteLine($"Playlist '{playlistName}' removed from user '{Username}'.");
            }
            else
            {
                Console.WriteLine($"Playlist '{playlistName}' not found for user '{Username}'.");
            }
        }

        // krijg de lijst van de playlists van de user
        public List<Playlist> GetPlaylists()
        {
            return Playlists;
        }
    }

}
}
