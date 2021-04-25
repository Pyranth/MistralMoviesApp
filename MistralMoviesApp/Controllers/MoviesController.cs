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
        private MoviesDbContext _context;
        private IMapper _mapper;
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
            if (text == null)
                text = "";

            var list = _context.Movies
                        .Include(m => m.Cast).ThenInclude(m => m.Actor)
                        .Include(m => m.Ratings);

            var result = list
                        .Where(m => m.Type == type)
                        .Where(m => m.Name.Contains(text) ||
                                    m.Description.Contains(text) ||
                                    m.Cast.Select(m => m.Actor).Any(m => m.Name.Contains(text)))
                        .OrderByDescending(m => m.Ratings.Average(r => r.Stars))
                        .Skip(loaded).Take(10);

            loaded += result.Count();

            ViewBag.Loaded = loaded;

            return PartialView(_mapper.Map<List<MovieListViewModel>>(result));
        }

        [AllowAnonymous]
        public IActionResult RateMovies()
        {
            var list = _context.Movies;

            return View(list);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult RateMovies(MoviesRatingPostModel model)
        { 
            for (int i = 0; i < model.Id.Count; i++)
            {
                if (model.Ratings[i] == null)
                    continue;

                _context.Ratings.Add(new Rating() { MovieId = model.Id[i], Stars = model.Ratings[i].Value });
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}