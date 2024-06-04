using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Test_Prog122_Week10_L14
{
    public class Movie
    {
        string _title;
        string _director;
        string _rating;

        public Movie(string title, string director, string rating)
        {
            _title = title;
            _director = director;
            _rating = rating;
        }

        public string Title { get => _title; set => _title = value; }
        public string Director { get => _director; set => _director = value; }
        public string Rating { get => _rating; set => _rating = value; }

        public override string ToString()
        {
            return $"{_title}, {_director}, {_rating}";
        }
    }
}
