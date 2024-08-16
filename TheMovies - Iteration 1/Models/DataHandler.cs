using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies___Iteration_1.Models
{
    public class DataHandler
    {
        private FileManager fileManager = new();
        public MoviesRepo moviesRepo = new();
        public List<Movie> Movies = new();

        public void LoadMovieRegistry()
        {
            Movies = fileManager.ReadFromCSVFile("test.csv");
        }
            
        
        public void LoadMovieRepo()
        {
            foreach (Movie movie in moviesRepo.movies)
            {
                Movies.Add(movie);
            }
        }
        


    }
}
