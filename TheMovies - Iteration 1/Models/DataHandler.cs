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
        public List<Movie> movies = new();

        public void LoadMovieRegistry()
        {
            movies = fileManager.ReadFromCSVFile("test.csv");
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }
            
        
        public void UpdateMovieRepo()
        {
            int duplicate = 0;

                for(int i = 0; i <= moviesRepo.movies.Count; i++)
                {
                    

                    if (moviesRepo.movies[i].MovieTitle == movies[i].MovieTitle)
                    {
                        //Found duplicate in the movie list, list already loaded
                        duplicate++;
                        break;
                    }

                }
                //No duplicates found in list, list not loaded yet
                if (duplicate == 0)
                {
                    foreach (Movie movie in moviesRepo.movies)
                    {
                        movies.Add(movie);
                    }
                }
                    
            }
        }

        


    }
}
