using Spotivy.Music;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create account
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to Spotivy!");
            Console.WriteLine(" ");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1: Create account");
            Console.BackgroundColor = ConsoleColor.Black;

            User user = new User();
            SongList songList = new SongList();

            List<Song> likedSongs = new List<Song>();

            var answer = Console.ReadLine();
            if (answer != null && answer == "1")
            {
                Console.WriteLine("Enter a username:");
                user.createUser(Console.ReadLine());
                optionsLoop();
            }

            void optionsLoop()
            {
                while (user.getUserAmount() >= 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("OPTIONS:");
                    Console.WriteLine("1: View song list");

                    Console.WriteLine("2: Create a playlist");
                    Console.WriteLine("3: View your friends");
                    Console.WriteLine("4: View your Liked songs");
                    Console.WriteLine(" ");
                    Console.WriteLine("MUSIC:");
                    Console.WriteLine("5: Play a song");
                    Console.WriteLine("6: Pause a song");
                    Console.WriteLine("7: Skip a song");
                    Console.WriteLine("8: Like a song");
                    Console.WriteLine(" ");
                    Console.WriteLine("PLAYLIST:");
                    Console.WriteLine("9: Add a song to a playlist");
                    Console.WriteLine("10: Play a playlist");
                    Console.WriteLine(" ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("type '0' to leave");
                    Console.BackgroundColor = ConsoleColor.Black;

                    var ans = Console.ReadLine();

                    if (ans != null && ans == "0")
                    {
                        Console.WriteLine("Exited!");
                        break;
                    }
                    else if (ans != null && ans == "1")
                    {
                        songList.DisplayAllSongs();
                        optionsLoop();

                    }
                    else if (ans != null && ans == "2")
                    {
                        Playlist playlist = new Playlist();
                        playlist.AddToPlaylist(songList);
                        optionsLoop();
                   }
                    else if (ans != null && ans == "3")
                    {
                        Console.WriteLine("friends");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "4")
                    {
                        Console.WriteLine("Liked songs:");
                        foreach (var song in likedSongs)
                        {
                            Console.WriteLine(song);
                        }
                        optionsLoop();
                    }
                    else if (ans != null && ans == "5")
                    {
                        Song.PlaySong(songList);
                        optionsLoop();

                    }
                    else if (ans != null && ans == "6")
                    {
                        Console.WriteLine("Paused song");
                        optionsLoop();
                    }
                    else if (ans != null && ans == "7")
                    {
                        Console.WriteLine("Skipped song");
                        optionsLoop();
                    }
                    else if (ans != null && ans == "8")
                    {
                        Console.WriteLine("Enter the ID of the song you want to like:");
                        if (int.TryParse(Console.ReadLine(), out int songId))
                        {
                            Song selectedSong = songList.GetSongById(songId);
                            if (selectedSong != null)
                            {
                                likedSongs.Add(selectedSong);
                                Console.WriteLine($"Liked {selectedSong.Title} by {selectedSong.Artist}.");
                            }
                            else
                            {
                                Console.WriteLine("Song not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID.");
                        }
                        optionsLoop();
                    }
                    else if (ans != null && ans == "9")
                    {
                        Console.WriteLine("Enter the name of the playlist you want to add a song to:");
                        string playlistName = Console.ReadLine();
                        Playlist playlist = Playlist.GetPlaylistByName(playlistName);
                        if (playlist != null)
                        {
                            Console.WriteLine("Enter the ID of the song you want to add:");
                            if (int.TryParse(Console.ReadLine(), out int songId))
                            {
                                Song selectedSong = songList.GetSongById(songId);
                                if (selectedSong != null)
                                {
                                    playlist.AddSong(selectedSong);
                                    Console.WriteLine($"Added {selectedSong.Title} to playlist {playlistName}.");
                                }
                                else
                                {
                                    Console.WriteLine("Song not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Playlist not found.");
                        }
                        optionsLoop();
                    }
                    else if (ans != null && ans == "10")
                    {
                        Playlist.PlayPlaylist();
                        optionsLoop();
                    }

                    
                    break;
                }
            }
        }
    }
}
