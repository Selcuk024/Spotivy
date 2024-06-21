using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Music
{
    internal class Track
    {
        private int id;
        string name;
        string producer;
        int timeInSeconds;
        bool playing = false;
        public Track(int id, string name, string artist)
        {
            this.id = id;
            this.name = name;
            this.producer = artist;
        }
        public int getTrackId()
        {
            return id;
        }
        public string getTrackName ()
        {
            return name;
        }
        public string getTrackProducer ()
        {
            return producer;
        }
        public string PlaySong()
        {
         if (playing == false){
                playing = true;
         }
            return playing;
        }
        public int getTrackTimeInSeconds()
        {
            return timeInSeconds;
        }
    }
}
