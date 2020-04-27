using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.Models
{
    public class MovieRepository
    {
        public interface IMovieRepository
        {
            IEnumerable<Movie> Movies { get;}

            void Create(Movie movie);

        }


        public class MoviRepository : IMovieRepository
        {
            private List<Movie> Data = new List<Movie>()
            {
                new Movie(1,"https://static.imovies.cc/movies/covers/510/788/878458788-55629b44e4705501bdf2a9ab835626b6.jpg","Trigger points"),
                new Movie(2,"https://static.imovies.cc/movies/posters/240/878/878368878-521466715eb101e824bfd7e8e0fc0e93.jpg","Shoplifter"),
                new Movie(3,"https://static.imovies.cc/movies/posters/240/768/878370768-1cf50966bca269630d09d435c08089a0.jpg","Joker"),
                new Movie(4,"https://static.imovies.cc/posters/1327091424829.jpg","Triggerman")
            };

            public IEnumerable<Movie> Movies => Data;

            public void Create(Movie movie)
            {
                var mv = Data.OrderBy(x => x.Id).LastOrDefault();
                movie.Id = mv != null ? mv.Id + 1 : 1;
                Data.Add(movie);
            }
        }
    }
}
