using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Infrastructure;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MistralMoviesApp.Models;

namespace MistralMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesDbContext _context;
        private IMapper _mapper;
        public MoviesController(MoviesDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int loaded = 0, string text = "")
        {
            if (text == null)
                text = "";

            var list = _context.Movies
                        .Include(m => m.Cast).ThenInclude(m => m.Actor)
                        .Include(m => m.Ratings);

            var result = list
                        .Where(m => m.Name.Contains(text) ||
                                    m.Description.Contains(text) ||
                                    m.Cast.Select(m => m.Actor).Any(m => m.Name.Contains(text)))
                        .OrderByDescending(m => m.Ratings.Average(r => r.Stars))
                        .Skip(loaded).Take(10);

            loaded += result.Count();

            ViewBag.Loaded = loaded;

            return PartialView(_mapper.Map<List<MovieListViewModel>>(result));
        }
    }
}