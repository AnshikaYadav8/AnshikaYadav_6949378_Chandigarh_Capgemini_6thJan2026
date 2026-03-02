using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApplicationProject
{
    enum Genre
    {
        Pop,
        Rock,
        Classical
    }
    struct Duration
    {
        public int Minutes;
        public int Seconds;
    }
    internal class SongDetails: SongInterface
    {
        public Genre SongGenre { get; set; }
        public Duration SongDuration;
        static int SongId = 0;
        string SongName;
        public string SongNameProperty
        {
            set
            {
                SongName = value;
            }
            get
            {
                return SongName;
            }
        }
        string SongArtist;
        public string SongArtistProperty
        {
            set
            {
                SongArtist = value;
            }
            get
            {
                return SongArtist; 
            }
        }
        public void SongInfo()
        {
            try
            {
                Console.WriteLine("Enter Song Name: ");
                this.SongName = Console.ReadLine();
                Console.WriteLine("Enter Artist Name: ");
                this.SongArtist = Console.ReadLine();
                Console.WriteLine("Enter Song Genre (1=Pop,2=Rock,3=Classical): ");
                int genreInput = Convert.ToInt32(Console.ReadLine())-1;
                SongGenre = (Genre)genreInput;
                Console.WriteLine("Enter song duration minutes: ");
                SongDuration.Minutes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter seconds: ");
                SongDuration.Seconds = Convert.ToInt32(Console.ReadLine());
                SongId++;
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Song Details: ");
            Console.WriteLine("Song Id: " + SongId);
            Console.WriteLine("Song Name: " + SongName);
            Console.WriteLine("Artist Name: " + SongArtist);
            Console.WriteLine("Genre: " + SongGenre);
            Console.WriteLine($"Duration: {SongDuration.Minutes}:{SongDuration.Seconds}");
        }
    }
}
