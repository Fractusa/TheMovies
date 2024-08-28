using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies___Iteration_1.Models
{
    public class MoviesRepo
    {
        public string movieTitle;
        public string movieGenre;
        public int movieLength;
        //private Movie movie;
        public List<Movie> movies = new();


        public void CreateMovie(string movieTitle, string movieGenre, int movieLength)
        {
            Movie currentMovie = new Movie(movieTitle, movieGenre, movieLength);
            movies.Add(currentMovie);

        }

        //public void CheckMovieList()
        //{
        //    foreach (Movie movie in movies)
        //    {
        //        Console.WriteLine(this.movie.MovieTitle);
        //    }

        //}

    }
}