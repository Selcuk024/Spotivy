using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Music
{
    internal class Track
    {
        int id = 0;
        string name;
        string producer;
        int timeInSeconds;
        bool playing = false;
        List<Track> tracks = new List<Track>();

        


        public Track(int TrackId, string trackName, string artist)
        {
            TrackId = id + 1;
            name = trackName;

        }
        public string getTrackName()
        {
            return name;
        }
        public int getTrackId()
        {
            return id;
        }

        public string getTrackProducer()
        {
            return producer;
        }
        public bool PlaySong()
        {
            if (playing == false)
            {
                playing = true;
            }
            return playing;
        }
        public bool StopSong()
        {
            if (playing == true)
            {
                playing = false;
            }
            return playing;
        }
        public int getTrackTimeInSeconds()
        {
            return timeInSeconds;
        }
    }
}
