using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheMovies___Iteration_1.Models;

//using TheMovies___Iteration_1.Models;
using TheMovies___Iteration_1.ViewModels;

namespace TheMovies___Iteration_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new();


        public MainWindow()
        {
            DataContext = mvm;
            InitializeComponent();
            

        }

        private void UpdateListBtn_Click(object sender, RoutedEventArgs e)
        {
            mvm.UpdateVMList();
        }

        private void LoadListBtn_Click(object sender, RoutedEventArgs e)
        {
            mvm.handler.LoadMovieRegistry();
        }

        private void btnCreateMovie_Click(object sender, RoutedEventArgs e)
        {
            //if(mvm.inputMovieTitle! && mvm.inputMovieGenre! && mvm.inputMovieLength)
            //{
            //    mvm.handler.CreateMovie(mvm.inputMovieTitle, mvm.inputMovieGenre, mvm.inputMovieLength);
            //    mvm.UpdateVMList();
            //}

            mvm.AddNewMovie();
            
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {                    
            mvm.fileManager.WriteToFile("test.txt", mvm.moviesVM.ToList());
        }

        private void btnDeleteMovie_Click(object sender, RoutedEventArgs e)
        {
            mvm.DeleteSelectedMovie();
        }

        private void btnCinemaProgram_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}