namespace MusicApplicationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details:");
            DisplayUser user = new DisplayUser();
            user.UserDetails();
            user.DisplayUserDetails();

            List<SongDetails> allSongs = new List<SongDetails>();
            Playlist<SongDetails> playlist = new Playlist<SongDetails>();

            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Add a song");
                Console.WriteLine("2. Display Song Details");
                Console.WriteLine("3. Add Song to Playlist");
                Console.WriteLine("4. Display Playlist");
                Console.WriteLine("5. Exit");

                int input1 = Convert.ToInt32(Console.ReadLine());

                switch (input1)
                {
                    case 1:
                        SongDetails song = new SongDetails();
                        song.SongInfo();
                        allSongs.Add(song);
                        Console.WriteLine("Song added successfully!");
                        break;

                    case 2:
                        if (allSongs.Count == 0)
                        {
                            Console.WriteLine("No songs added yet!");
                        }
                        else
                        {
                            Console.WriteLine("All Songs:");
                            for (int i = 0; i < allSongs.Count; i++)
                            {
                                Console.WriteLine($"\nSong {i + 1}:");
                                allSongs[i].DisplayDetails();
                            }
                        }
                        break;

                    case 3:
                        if (allSongs.Count == 0)
                        {
                            Console.WriteLine("No songs available to add to playlist.");
                        }
                        else
                        {
                            Console.WriteLine($"Choose a song (1-{allSongs.Count}):");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            if (choice >= 1 && choice <= allSongs.Count)
                            {
                                playlist.AddToPlaylist(allSongs[choice - 1]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice!");
                            }
                        }
                        break;

                    case 4:
                        playlist.ShowPlaylist();
                        break;

                    case 5:
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
