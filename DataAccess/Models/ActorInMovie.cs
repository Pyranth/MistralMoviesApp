using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class ActorInMovie
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
    }
}
