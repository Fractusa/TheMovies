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
        public List<CinemaHall> cinemaHalls = new();
        public CinemaHall cinemaHall = new();

        public void LoadMovieRegistry()
        {
            movies = fileManager.ReadFromCSVFile("test.txt");
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }
        public List<CinemaHall> GetCinemaHalls()
        {
            return cinemaHalls;
        }

        public void AddMovie(string movieTitle, string movieGenre, int movieLength)
        {            
            Movie currentMovie = new Movie(movieTitle, movieGenre, movieLength);

            movies.Add(currentMovie);
        }

        public void AddMovie(string movieTitle, string movieGenre, int movieLength, string movieDirector, DateOnly premiereDate, int cinemaHall)
        {
            Movie currentMovie = new Movie(movieTitle, movieGenre, movieLength, movieDirector, premiereDate, cinemaHall);

            movies.Add(currentMovie);
        }

        public void CreateCinemaHall(int cinemaHallNumber, int playTime, DateOnly dateStart, DateOnly dateEnd)
        {

            CinemaHall currentCinemaHall = new CinemaHall(cinemaHallNumber, playTime, dateStart, dateEnd);
            cinemaHalls.Add(currentCinemaHall);
        }
        public void CreateCinemaHall(CinemaHall currentCinemaHall)
        {

            currentCinemaHall = new CinemaHall(currentCinemaHall);
            cinemaHalls.Add(currentCinemaHall);
        }

        public void UpdateMovieRepo()
        {
            int duplicate = 0;
                
                if(moviesRepo.movies.Count != 0)
                {
                    for (int i = 0; i <= moviesRepo.movies.Count; i++)
                    {


                        if (moviesRepo.movies[i].MovieTitle == movies[i].MovieTitle)
                        {
                            //Found duplicate in the movie list, list already loaded
                            duplicate++;
                            break;
                        }

                    }
                }
                
                //No duplicates found in list, list not loaded yet. Therefor load the list.
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

