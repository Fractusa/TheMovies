using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies___Iteration_1.Models
{
    public class Movie
    {
        private string movieTitle;
        private string movieGenre;
        private int movieLength;

        public string MovieTitle
        { get; set; }
        
        public string MovieGenre
        {  get; set; }

        public int MovieLength
            { get; set; }
      
        public Movie(string movieTitle, string movieGenre, int movieLength)
        {
            this.MovieTitle = movieTitle;
            this.MovieGenre = movieGenre;
            this.MovieLength = movieLength;
        }

        public Movie()
        {

        }
    }
}
