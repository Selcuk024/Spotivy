<<<<<<< HEAD
﻿using System.Security.Cryptography.X509Certificates;
=======
﻿using Spotivy.Music;
>>>>>>> 1c2d601fb8d1e35ea5dd087b69f4f47dafa4e12b

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //create account
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to Spotivy!");
            Console.WriteLine(" ");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1: Create account");
            Console.BackgroundColor = ConsoleColor.Black;
=======
            Console.WriteLine("Hello, World!");
            Track track = new Track(1, "test", "test");
            List<Track> trackList = new List<Track>();
            
            bool playing = track.PlaySong();
            string songName = track.getTrackName();
            if (playing == true)
            {
                Console.WriteLine("song is playing");
            }
>>>>>>> 1c2d601fb8d1e35ea5dd087b69f4f47dafa4e12b
            User user = new User();


            //user aanmaken
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
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("2: View your playlists");
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
                    Console.WriteLine("9: ???");
                    Console.WriteLine("10: ???");
                    Console.WriteLine(" ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("type '0' to leave");
                    Console.BackgroundColor = ConsoleColor.Black;

                    var ans = Console.ReadLine();

                    if (ans != null && ans == "0") {
                        Console.WriteLine("Exited!");
                        break;
                    } else if (ans != null && ans == "1")
                    {
                        Console.WriteLine("song list");
                    }

                    //ending loop and waiting for re-trigger
                    break;
                }
            }

        }
    }
}
