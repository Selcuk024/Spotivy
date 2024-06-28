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
            songs = new List<Song>();
            LoadSongs();
        }

        public void LoadSongs()
        {
            // Hardcoded list of songs
            songs.Add(new Song(1, "Bohemian Rhapsody", "Rock", "Queen", "A Night at the Opera", 354));
            songs.Add(new Song(2, "Hotel California", "Rock", "Eagles", "Hotel California", 391));
            songs.Add(new Song(3, "Bohemian Like You", "Alternative Rock", "The Dandy Warhols", "Thirteen Tales from Urban Bohemia", 235));
            songs.Add(new Song(4, "Africa", "Rock", "Toto", "Toto IV", 295));
            songs.Add(new Song(5, "Zoutelande", "Pop", "BLØF", "Aan", 220));
            songs.Add(new Song(6, "Viva La Vida", "Alternative Rock", "Coldplay", "Viva la Vida or Death and All His Friends", 242));
            songs.Add(new Song(7, "Mag Het Licht Uit", "Rock", "De Dijk", "Wakker in een Vreemde Wereld", 295));
            songs.Add(new Song(8, "Wonderwall", "Britpop", "Oasis", "(What's the Story) Morning Glory?", 259));
            songs.Add(new Song(9, "Ik Heb Je Lief", "Pop", "Paul de Leeuw", "Mijn Houten Hart", 196));
            songs.Add(new Song(10, "Fix You", "Alternative Rock", "Coldplay", "X&Y", 294));
            songs.Add(new Song(11, "Paradise by the Dashboard Light", "Rock", "Meat Loaf", "Bat Out of Hell", 512));
            songs.Add(new Song(12, "Iedereen Is Van De Wereld", "Rock", "The Scene", "Blauw", 268));
            songs.Add(new Song(13, "Shape of You", "Pop", "Ed Sheeran", "÷ (Divide)", 233));
            songs.Add(new Song(14, "Huilend Naar De Club", "Pop", "Suzan & Freek", "Huilend Naar De Club", 190));
            songs.Add(new Song(15, "Enter Sandman", "Metal", "Metallica", "Metallica", 331));
            songs.Add(new Song(16, "Het Is Een Nacht", "Pop", "Guus Meeuwis", "Verbazing", 270));
        }

        public void DisplayAllSongs()
        {
            List<Song> songs = GetAllSongs();
            Console.WriteLine("\nAll Songs:");
            foreach (Song song in songs)
            {
                Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Album: {song.Album}, Duration: {song.SongDuration}, Genre: {song.Genre}, ID: {song.Id} ");
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
