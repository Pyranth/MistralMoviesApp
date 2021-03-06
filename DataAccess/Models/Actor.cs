using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ActorInMovie> Movies { get; set; }
    }
}
