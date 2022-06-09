
using InventoryBeginners.Repositories;
using InventoryBeginners.Interfaces;
using InventoryBeginners.Models;
using InventoryBeginners.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryBeginners.Repositories
{
    public class MovieRepository : iMovie
    {
        private readonly InventoryContext _Context;
        public MovieRepository(InventoryContext context)
        {
                _Context = context;
        }

        public Movie Create(Movie movie)
        {
           
            _Context.Movies.Add(movie);
            _Context.SaveChanges();
            return movie; 
        }

        public Movie Delete(Movie movie)
        {
            _Context.Movies.Attach(movie);
            _Context.Entry(movie).State = EntityState.Deleted;
            _Context.SaveChanges();
            return movie;
        }

        public Movie Edit(Movie movie)
        {
            _Context.Movies.Attach(movie);
            _Context.Entry(movie).State = EntityState.Modified;
            _Context.SaveChanges();
            return movie;
        }

        public List<Movie> GetItems()
        {
            List<Movie> movies = _Context.Movies.ToList();
            return movies;
        }

        public Movie GetMovie(int id)
        {
            
                Movie movie = _Context.Movies.Where(u => u.ID == id).FirstOrDefault();
                return movie;
            
        }

      
    }


}
