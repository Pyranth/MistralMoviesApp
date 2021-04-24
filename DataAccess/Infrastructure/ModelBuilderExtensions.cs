using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Infrastructure
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Movie>().HasData();
        }
    }
}
