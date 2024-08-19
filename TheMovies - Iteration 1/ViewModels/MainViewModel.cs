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
        public DataHandler handler = new();
        public FileManager fileManager = new();

        public MainViewModel()
        {

            moviesVm = new ObservableCollection<Movie>();
            List<Movie> movies = new();

        }

        public ObservableCollection<Movie> moviesVm
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

        public void DeleteSelectedMovie()
        {
            if (SelectedMovie != null)
            {

            }
        }

        public void AddNewMovie()
        {
            Movie newMovie = new Movie
            {
                MovieTitle = "Skriv navn på film",
                MovieGenre = "Skriv genre på film",
                MovieLength = 0
            };


        }
        public void UpdateVmList()
        {
            handler.UpdateMovieRepo();
            List<Movie> moviesVmList = handler.GetMovies();
            foreach (Movie movie in moviesVmList)
            {
                moviesVm.Add(movie);
            }
        }
    }
}
