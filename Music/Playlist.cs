﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Music
{
    internal class Playlist
    {
        private string name;
        private List<Track> tracks;
        //moet een list van tracks zijn ipv string

        public void addTrack(string track, List<Track> tracks)
        {
            //string moet een track worden
        }

        public void play(List<Track> tracks)
        {
            //play first track in queue
        }
    }
}