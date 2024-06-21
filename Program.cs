using Spotivy.Music;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Track track = new Track();
            track.PlaySong();
            if (playing == true) {
                Console.WriteLine("playing song");
            }
        }
    }
}
