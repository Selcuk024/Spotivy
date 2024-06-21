using Spotivy.Music;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Track track = new Track(1, "test", "test");
            List<Track> trackList = new List<Track>();
            
            bool playing = track.PlaySong();
            string songName = track.getTrackName();
            if (playing == true)
            {
                Console.WriteLine("song is playing");
            }
            User user = new User();
            user.createUser("Daan");
            user.createUser("Selcuk");
        }
    }
}
