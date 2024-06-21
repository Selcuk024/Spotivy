using System;
using System.Collections.Generic;

namespace Spotivy.Music
{
    internal class Track
    {
        private static int idCounter = 0;
        private int id;
        private string name;
        private string producer;
        private int timeInSeconds;
        private bool playing;
        private static List<Track> tracks = new List<Track>();

        public Track(string trackName, string producerTrack, int timeInSecond)
        {
            id = ++idCounter; 
            name = trackName;
            producer = producerTrack;
            timeInSeconds = timeInSecond;
            playing = false;
        }

        public static Track CreateTrack(string trackName, string producer, int timeInSeconds)
        {
            Track newTrack = new Track(trackName, producer, timeInSeconds);
            tracks.Add(newTrack);
            return newTrack;
        }

        public string GetTrackName()
        {
            return name;
        }

        public int GetTrackId()
        {
            return id;
        }

        public string GetTrackProducer()
        {
            return producer;
        }

        public bool PlaySong()
        {
            if (!playing)
            {
                playing = true;
            }
            return playing;
        }

        public bool StopSong()
        {
            if (playing)
            {
                playing = false;
            }
            return playing;
        }

        public int GetTrackTimeInSeconds()
        {
            return timeInSeconds;
        }
    }
}
