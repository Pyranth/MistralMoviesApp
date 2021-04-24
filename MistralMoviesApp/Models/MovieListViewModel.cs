using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace MistralMoviesApp.Models
{
    public class MovieListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
