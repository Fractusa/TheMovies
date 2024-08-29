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
        private int playtime;
        private DateOnly dateStart;
        private DateOnly dateEnd;
        private Movie movie = new Movie();
        public List<Movie> scheduledMovies = new();

        public int CinemaHallNumber
        { get; set; }

        public int Playtime
        { get; set; }

        public DateOnly DateStart
        { get; set; }

        public DateOnly DateEnd
        { get; set; }

        public CinemaHall(int cinemaHallNumber, int playtime, DateOnly dateStart, DateOnly dateEnd)
        {
            this.cinemaHallNumber = cinemaHallNumber;
            this.playtime = playtime;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }
        public CinemaHall(CinemaHall currentCinemaHall)
        {
            this.cinemaHallNumber = currentCinemaHall.cinemaHallNumber;
            this.playtime = currentCinemaHall.playtime;
            this.dateStart = currentCinemaHall.dateStart;
            this.dateEnd = currentCinemaHall.dateEnd;
        }
        public CinemaHall()
        {

        }

        public void AddMovieToSchedule(Movie addedMovie)
        {
            //if((Playtime + 30) >= addedMovie.MovieLength)
            //{
                playtime = -(addedMovie.MovieLength + 30);
                scheduledMovies.Add(addedMovie);
            //}
        }

    }
}
