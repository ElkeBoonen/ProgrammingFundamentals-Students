using System;
using System.Collections.Generic;
using System.Text;

namespace FRONTEND___DSPS
{
    class Song
    {
        private int id { get; set; }
        public string title { get; set; }
        public int artist { get; set; }
        public string spotify { get; set; }

        public Song(string title, int artist, string spotify)
        {
            this.title = title;
            this.artist = artist;
            this.spotify = spotify;
        }

        public override string ToString()
        {
            return $"{id} - {title} ({artist})\n\tListen on {spotify}";
        }
    }
}
