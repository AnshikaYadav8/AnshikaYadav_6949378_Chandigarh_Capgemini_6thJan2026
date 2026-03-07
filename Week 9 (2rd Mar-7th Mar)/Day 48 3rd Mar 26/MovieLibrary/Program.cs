using System;
using System.Collections.Generic;
using System.Linq;

interface IMovie
{
    int Id { get; set; }
    string Title { get; set; }
    string Genre { get; set; }
    double Rating { get; set; }
}

interface IMovieLibrary
{
    void AddMovie(IMovie movie);
    void RemoveMovie(int id);
    List<IMovie> GetMoviesByGenre(string genre);
    IMovie GetTopRatedMovie();
}

class Movie : IMovie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }
}

class MovieLibrary : IMovieLibrary
{
    private List<IMovie> movies = new List<IMovie>();

    public void AddMovie(IMovie movie)
    {
        movies.Add(movie);
    }

    public void RemoveMovie(int id)
    {
        var m = movies.FirstOrDefault(x => x.Id == id);
        if (m != null)
            movies.Remove(m);
    }

    public List<IMovie> GetMoviesByGenre(string genre)
    {
        return movies.Where(m => m.Genre == genre).ToList();
    }

    public IMovie GetTopRatedMovie()
    {
        return movies.OrderByDescending(m => m.Rating).FirstOrDefault();
    }
}

class Program
{
    static void Main()
    {
        IMovieLibrary library = new MovieLibrary();

        library.AddMovie(new Movie { Id = 1, Title = "Inception", Genre = "SciFi", Rating = 8.8 });
        library.AddMovie(new Movie { Id = 2, Title = "Titanic", Genre = "Romance", Rating = 7.9 });
        library.AddMovie(new Movie { Id = 3, Title = "Interstellar", Genre = "SciFi", Rating = 8.6 });

        Console.WriteLine("SciFi Movies:");
        foreach (var m in library.GetMoviesByGenre("SciFi"))
        {
            Console.WriteLine($"{m.Title} Rating: {m.Rating}");
        }

        var top = library.GetTopRatedMovie();
        Console.WriteLine("Top Rated Movie: " + top.Title);
    }
}