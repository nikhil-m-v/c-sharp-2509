using System;

namespace Assignment_Part_5
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Year: {Year}");
        }
    }

    public class MovieLibrary
    {
        private Movie[] movies;

        public MovieLibrary(int movieCount)
        {
            movies = new Movie[movieCount];
        }

        public Movie this[int index]
        {
            get { return movies[index]; }
            set { movies[index] = value; }
        }

        public void DisplayMovies()
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
            }
        }
    }
}