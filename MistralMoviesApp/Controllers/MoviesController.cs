using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Infrastructure;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MistralMoviesApp.Models;

namespace MistralMoviesApp.Controllers
{
    public class MoviesController : BaseController
    {
        // Context for reading/writing data from DB
        private MoviesDbContext _context;
        // Service for easy mapping between objects
        private IMapper _mapper;
        // Service for getting data about host enviroment 
        private IWebHostEnvironment _env;

        public MoviesController(MoviesDbContext context, IMapper mapper, IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        [AllowAnonymous]
        public IActionResult List(int loaded = 0, string text = "", MovieType type = MovieType.MOVIE)
        {
            // Quick workaround
            // Make this work in ModelBinder
            if (text == null)
                text = "";

            // Get Movies, join Actors and Ratings
            var list = _context.Movies
                        .Include(m => m.Cast).ThenInclude(m => m.Actor)
                        .Include(m => m.Ratings);

            // Search movies based on type, search text and order by rating, using pagination
            var result = list
                        .Where(m => m.Type == type)
                        .Where(m => m.Name.Contains(text) ||
                                    m.Description.Contains(text) ||
                                    m.Cast.Select(m => m.Actor).Any(m => m.Name.Contains(text)))
                        .OrderByDescending(m => m.Ratings.Average(r => r.Stars))
                        .Skip(loaded).Take(10);

            // Get ammount of showed items on front-end
            loaded += result.Count();

            ViewBag.Loaded = loaded;

            // Map data to view model and render partial view
            return PartialView(_mapper.Map<List<MovieListViewModel>>(result));
        }

        [AllowAnonymous]
        public IActionResult RateMovies()
        {
            // Get list of all movies for purpose of rating
            var list = _context.Movies;

            return View(list);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult RateMovies(MoviesRatingPostModel model)
        { 
            // Get list of movie IDs and selected ratings
            // Better solution - should be done using proper view model and mapping to Rating model list.
            for (int i = 0; i < model.Id.Count; i++)
            {
                if (model.Ratings[i] == null)
                    continue;

                // For each selected rating, insert to DB
                _context.Ratings.Add(new Rating() { MovieId = model.Id[i], Stars = model.Ratings[i].Value });
            }

            // Save changes to DB
            _context.SaveChanges();

            // Return to list of all movies with updated ratings
            return RedirectToAction("Index", "Home");
        }
    }
}