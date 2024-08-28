using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies___Iteration_1.Models
{
    public class CinemaHall
    {
        private int cinemaHallNumber;
        private int playTime;
        private DateOnly dateStart;
        private DateOnly dateEnd;
        private Movie movie = new Movie();
        public List<Movie> scheduledMovies = new();

        public int CinemaHallNumber
        { get; set; }

        public int PlayTime
        { get; set; }

        public DateOnly DateStart
        { get; set; }

        public DateOnly DateEnd
        { get; set; }

        public CinemaHall(int cinemaHallNumber, int playTime, DateOnly dateStart, DateOnly dateEnd)
        {
            this.cinemaHallNumber = cinemaHallNumber;
            this.playTime = playTime;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }

        public void AddMovieToSchedule(Movie addedMovie)
        {
            if((PlayTime + 30) >= addedMovie.MovieLength)
            {
                playTime = -(addedMovie.MovieLength + 30);
                scheduledMovies.Add(addedMovie);
            }
        }
    }
}
