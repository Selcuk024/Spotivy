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
        private string name;
        private string producer; 
        private int timeInSeconds;

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
        public int getTrackTimeInSeconds()
        {
            return timeInSeconds;
        }
    }
}
