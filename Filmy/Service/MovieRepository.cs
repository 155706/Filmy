using Filmy.Context;
using Filmy.Interface;
using Filmy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Service
{
    public class MovieRepository : IMovieRepository
    {
        private readonly InstrukcjaDbContext context;
        public MovieRepository(InstrukcjaDbContext _context)
        {
            context = _context;
        }
        public Movie Delete(int movieId)
        {
            Movie movie = context.Movies.Find(movieId);
            if (movie != null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }
            return movie;
        }
        public Movie Get(int movieId)
        {
            return context.Movies.Find(movieId);
        }
        public IEnumerable<Movie> GetAll()
        {
            return context.Movies;
        }
        public Movie Post(Movie newMovie)
        {
            context.Movies.Add(newMovie);
            context.SaveChanges();
            return newMovie;
        }

        public Movie Put(Movie updatedMovie)
        {
            throw new NotImplementedException();
        }
    }
}
