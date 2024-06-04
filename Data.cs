using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test_Prog122_Week10_L14
{
    static class Data
    {
        static ObservableCollection<Movie> movies;

        static Data()
        {
            movies = new ObservableCollection<Movie>();
            


        }

        public static ObservableCollection<Movie> Movies { get { return movies; } }

        public static void AddMovie(string title, string author, string rating)
        {
            Movies.Add(new Movie(title, author, rating));
        }
    }
}
