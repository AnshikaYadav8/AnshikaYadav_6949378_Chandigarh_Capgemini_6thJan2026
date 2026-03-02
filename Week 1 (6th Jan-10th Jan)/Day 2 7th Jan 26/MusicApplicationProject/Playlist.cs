using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApplicationProject
{
    internal class Playlist<T> where T: SongInterface
    {
        private List<T> playlist = new List<T>();
        public void AddToPlaylist(T song)
        {
            playlist.Add(song);
            Console.WriteLine("Added to playlist!");
        }
        public void ShowPlaylist()
        {
            Console.WriteLine("Playlist:");
            foreach (var i in playlist)
            {
                i.DisplayDetails();
            }
        }
    }
}
