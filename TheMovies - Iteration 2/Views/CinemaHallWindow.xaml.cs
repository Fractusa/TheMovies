using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TheMovies___Iteration_1.Models;
using TheMovies___Iteration_1.ViewModels;

namespace TheMovies___Iteration_1.Views
{
    /// <summary>
    /// Interaction logic for CinemaHallWindow.xaml
    /// </summary>
    public partial class CinemaHallWindow : Window 
    {
        MainViewModel mvm = new();
        public CinemaHallWindow()
        {
            InitializeComponent();
            DataContext = mvm;

        }

       
        private void AddCinemaHallButton_Click(object sender, RoutedEventArgs e)
        {
            mvm.AddNewCinemaHall();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {

        }

        private void addMovieToSchedule_Click(object sender, RoutedEventArgs e)
        {
            mvm.handler.cinemaHall.AddMovieToSchedule(mvm.SelectedMovie);
        }
    }
}
