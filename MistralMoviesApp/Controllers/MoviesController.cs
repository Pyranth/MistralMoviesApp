using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace MistralMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesDbContext _context;
        public MoviesController(MoviesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int loaded = 0, string text = "")
        {
            if (text == null)
                text = "";

            var list = _context.Movies;

            var result = list.Where(m => m.Name.Contains(text)).Skip(loaded).Take(10);

            loaded += result.Count();

            ViewBag.Loaded = loaded;

            return PartialView(result);
        }
    }
}