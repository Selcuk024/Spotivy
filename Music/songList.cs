using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Music
{
    internal class SongList
    {
        private List<Song> songs;

        public SongList()
        {
            songs = new List<Song>
            {
                new Song(1, "Never Gonna Give You Up", "Pop", "Rick Astley", "Whenever You Need Somebody", 215),
                new Song(2, "Shape of You", "Pop", "Ed Sheeran", "Divide", 240),
                new Song(3, "Bohemian Rhapsody", "Rock", "Queen", "A Night at the Opera", 354),
                new Song(4, "Billie Jean", "Pop", "Michael Jackson", "Thriller", 294),
                new Song(5, "Smells Like Teen Spirit", "Grunge", "Nirvana", "Nevermind", 301),
                new Song(6, "Imagine", "Pop", "John Lennon", "Imagine", 183),
                new Song(7, "Stairway to Heaven", "Rock", "Led Zeppelin", "Led Zeppelin IV", 482),
                new Song(8, "Uptown Funk", "Funk", "Mark Ronson ft. Bruno Mars", "Uptown Special", 269),
                new Song(9, "Hotel California", "Rock", "Eagles", "Hotel California", 391),
                new Song(10, "Rolling in the Deep", "Pop", "Adele", "21", 228),
                new Song(11, "Take on Me", "Pop", "a-ha", "Hunting High and Low", 213),
                new Song(12, "Hallelujah", "Rock", "Jeff Buckley", "Grace", 217),
                new Song(13, "Sweet Child o' Mine", "Hard Rock", "Guns N' Roses", "Appetite for Destruction", 356),
                new Song(14, "Rolling in the Deep", "Pop", "Adele", "21", 228),
                new Song(15, "Purple Rain", "Rock", "Prince", "Purple Rain", 520),
                new Song(16, "Het is een nacht", "Nederpop", "Guus Meeuwis", "Verbazing", 225),
                new Song(17, "Hey Brother", "Country", "Avicii", "True", 255),
                new Song(18, "Zij gelooft in mij", "Nederpop", "Andre Hazes", "De Hazes 100", 229)
            };
        }

        public void DisplayAllSongs()
        {
            List<Song> songs = GetAllSongs();
            Console.WriteLine("\nAll Songs:");
            foreach (Song song in songs)
            {
                Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Album: {song.Album}, Duration: {song.SongDuration}, Genre: {song.Genre}, ID: {song.Id}");
            }
        }

        public List<Song> GetAllSongs()
        {
            return songs;
        }

        public Song GetSongById(int id)
        {
            return songs.Find(song => song.Id == id);
        }
    }
}
