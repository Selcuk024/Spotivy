using Spotivy.Music;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create account
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to Spotivy!");
            Console.WriteLine(" ");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1: Create account");
            Console.BackgroundColor = ConsoleColor.Black;

            User user = new User();
            SongList songList = new SongList();


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
                    //Console.BackgroundColor = ConsoleColor.Red;
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
                        songList.DisplayAllSongs();
                        optionsLoop();
                    } else if (ans != null && ans == "2")
                    {
                        Console.WriteLine("playlists");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "3")
                    {
                        Console.WriteLine("friends");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "4")
                    {
                        Console.WriteLine("liked songs");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "5")
                    {
                        Console.WriteLine("play song");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "6")
                    {
                        Console.WriteLine("pause song");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "7")
                    {
                        Console.WriteLine("skip song");
                        optionsLoop();

                    }
                    else if (ans != null && ans == "8")
                    {
                        Console.WriteLine("like song");
                        optionsLoop();

                    }

                    //ending loop and waiting for re-trigger
                    break;
                }
            }

        }
    }
}
