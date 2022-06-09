using InventoryBeginners.Data;
using InventoryBeginners.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using InventoryBeginners.Interfaces;
using InventoryBeginners.Repositories;

namespace InventoryBeginners.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = _iMovieRepo .GetItems();
            return View(movies);
        }

        
        private readonly iMovie _iMovieRepo;
        public MoviesController(iMovie movieRepo)
        {
          
            _iMovieRepo = movieRepo;
        }
         
        public IActionResult Create()
        {
            Movie movie = new Movie();
            return View(movie);
        }

        [HttpPost]

        public IActionResult Create(Movie movie)
        {
            try
            {
                movie = _iMovieRepo.Create(movie); 
            }
            catch
            {
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            Movie movie = _iMovieRepo.GetMovie(id);
            return View(movie);
        }
       


       
        public IActionResult Edit(int id)
        {
            Movie movie = _iMovieRepo.GetMovie(id);
            return View(movie);
        }

        [HttpPost]

        public IActionResult Edit(Movie movie)
        {
            try
            {
                movie = _iMovieRepo.Edit(movie);
            }
            catch
            {
            }

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            Movie movie = _iMovieRepo.GetMovie(id);
            return View(movie);
        }


        [HttpPost]

        public IActionResult Delete(Movie movie)
        {
            try
            {
                movie = _iMovieRepo.Delete(movie);
            }
            catch
            {
            }

            return RedirectToAction(nameof(Index));
        }

    }


}
