using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies___Iteration_1.Models
{
    public class FileManager
    {
        private string fileName;
        //private DataHandler handler = new();

        public string ConvertToString(Movie typeToConvert)
        {
            string convertMovieToString;

            if (typeToConvert is Movie movie)
            {
                convertMovieToString = $"{movie.MovieTitle},{movie.MovieGenre},{movie.MovieLength}";
            }
            else
            {
                return convertMovieToString = "Conversion failed";
            }

            return convertMovieToString;
        }

        public string FileName
        {  get { return fileName; } set { fileName = value; } }

        public void WriteToFile(string fileName, List<Movie> moviesToWrite)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Movie movie in moviesToWrite)
                {
                    string toWrite = ConvertToString(movie);
                    sw.WriteLine(toWrite);
                }
            }
        }

        //public List<Movie> ReadFromCSVFile(string fileName)
        //{
        //    List<Movie> movies = new();

        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(fileName))
        //        {
        //            string line;

        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                string[] lineArray = line.Split(",");

        //                Movie movie = new Movie(lineArray[0], lineArray[1], int.Parse(lineArray[2]));

        //                movies.Add(movie);
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        new Exception("Something went wrong loading your file");
        //    }

        //    return movies;
        //}

        public List<Movie> ReadFromCSVFile(string fileName)
        {
            List<Movie> movies = new();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(",");

                        Movie movie = new Movie(lineArray[0], lineArray[1], int.Parse(lineArray[2]), lineArray[3],
                            DateOnly.ParseExact(lineArray[4], "MM-dd-yyyy"), int.Parse(lineArray[5]));

                        movies.Add(movie);
                    }
                }
            }

            catch (Exception ex)
            {
                new Exception("Something went wrong loading your file");
            }

            return movies;
        }
    }
}
