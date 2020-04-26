using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.Models
{
    public class Movie
    {
        public Movie() { }
        public Movie(int id, string thumb, string title)
        {
            Id = id;
            Thumb = thumb;
            Title = title;
        }


        public int  Id { get; set; }

        public string Thumb { get; set; }

        public string Title { get; set; }
    }
}
