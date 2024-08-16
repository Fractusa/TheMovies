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

        public string FileName
        {  get { return fileName; } set { fileName = value; } }

        public void WriteToFile(string fileName, List<Movie> moviesToWrite)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Movie movie in moviesToWrite)
                {
                    sw.WriteLine(movie);
                }
            }
        }

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

                        Movie movie = new Movie(lineArray[0], lineArray[1], int.Parse(lineArray[2]));

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
