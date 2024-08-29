using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies___Iteration_1.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace TheMovies___Iteration_1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Movie selectedMovie;
        private CinemaHall selectedCinemaHall;
        public DataHandler handler = new();
        public FileManager fileManager = new();
        public MoviesRepo moviesRepo = new();

        public MainViewModel()
        {
            handler.LoadMovieRegistry();
            moviesVM = new ObservableCollection<Movie>();
            cinemaHallsVM = new ObservableCollection<CinemaHall>();
            List<Movie> movies = handler.GetMovies();
            List<CinemaHall> cinemaHalls = handler.GetCinemaHalls();

            foreach (Movie movie in movies)
            {
                moviesVM.Add(movie);
            }
        }

        public ObservableCollection<Movie> moviesVM
        { get; set; }
        public ObservableCollection<CinemaHall> cinemaHallsVM
        { get; set; }
        public ObservableCollection<Movie> movieScheduleVM
        { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Movie SelectedMovie
        {
            get { return selectedMovie; }

            set
            {
                selectedMovie = value;
                OnPropertyChanged(nameof(SelectedMovie));
            }
        }
        public CinemaHall SelectedCinemaHall
        {
            get { return selectedCinemaHall; }

            set
            {
                selectedCinemaHall = value;
                OnPropertyChanged(nameof(SelectedMovie));
            }
        }

        public void DeleteSelectedMovie()
        {
            if (SelectedMovie != null)
            {
                moviesVM.Remove(SelectedMovie);
                moviesRepo.movies.Remove(SelectedMovie);
                SelectedMovie = null;
            }
        }

        public void AddNewMovie()
        {
            Movie newMovie = new Movie
            {
                MovieTitle = "Skriv navn på film",
                MovieGenre = "Skriv genre på film",
                MovieLength = 0,
                MovieDirector = "Skriv navn på instruktør",
                PremiereDate = DateOnly.MaxValue,
                CinemaHall = 0
            };

            handler.AddMovie("Skriv navn på film", "Skriv genre på film", 0, "Skriv navn på instruktør", DateOnly.MaxValue, 0);
            moviesVM.Add(newMovie);
            moviesRepo.movies.Add(newMovie);

            SelectedMovie = newMovie;
        }

        public void AddNewCinemaHall()
        {
            CinemaHall newCinemaHall = new CinemaHall
            {
                CinemaHallNumber = 1,
                Playtime = 100,
                DateStart = DateOnly.MinValue,
                DateEnd = DateOnly.MaxValue,
            };

            handler.CreateCinemaHall(newCinemaHall);
            cinemaHallsVM.Add(newCinemaHall);


        }
        public void UpdateVMList()
        {
            moviesVM.Clear();
            cinemaHallsVM.Clear();
            

            handler.UpdateMovieRepo();
            List<Movie> moviesVmList = handler.GetMovies();
            List<CinemaHall> cinemaHalls = handler.GetCinemaHalls();

            foreach (Movie movie in moviesVmList)
            {
                moviesVM.Add(movie);
            }
            foreach (CinemaHall cinemaHall in cinemaHalls)
            {
                cinemaHallsVM.Add(cinemaHall);
            }
        }
    }
}
