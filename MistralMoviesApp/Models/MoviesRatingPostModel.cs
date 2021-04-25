using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MistralMoviesApp.Models
{
    public class MoviesRatingPostModel
    {
        public List<int> Id { get; set; }
        public List<int?> Ratings { get; set; }
    }
}
