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
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Name = "The Shawshank Redemption", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 2, Name = "The Godfather", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 3, Name = "The Godfather: Part II", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 4, Name = "The Dark Knight", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 5, Name = "12 Angry Men", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 6, Name = "Schindler's List", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 7, Name = "The Lord of the Rings: The Return of the King", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 8, Name = "Pulp Fiction", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 9, Name = "The Good, the Bad and the Ugly", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 10, Name = "The Lord of the Rings: The Fellowship of the Ring", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)},
                new Movie() { Id = 11, Name = "Fight Club", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4)}
                );
        }
    }
}
