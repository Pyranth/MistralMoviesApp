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
                // Movies
                new Movie() { Id = 1, Name = "The Shawshank Redemption", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 2, Name = "The Godfather", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 3, Name = "The Godfather: Part II", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 4, Name = "The Dark Knight", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 5, Name = "12 Angry Men", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 6, Name = "Schindler's List", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 7, Name = "The Lord of the Rings: The Return of the King", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 8, Name = "Pulp Fiction", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 9, Name = "The Good, the Bad and the Ugly", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 10, Name = "The Lord of the Rings: The Fellowship of the Ring", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 11, Name = "Forrest Gump", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 12, Name = "Inception", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 13, Name = "The Lord of the Rings: The Two Towers", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                new Movie() { Id = 14, Name = "Star Wars: Episode V - The Empire Strikes Back", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.MOVIE},
                // TV Shows
                new Movie() { Id = 15, Name = "Planet Earth", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.TV_SHOW},
                new Movie() { Id = 16, Name = "Band of Brothers", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.TV_SHOW},
                new Movie() { Id = 17, Name = "Breaking Bad", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.TV_SHOW},
                new Movie() { Id = 18, Name = "Chernobyl", Description = "", CoverImage = "", ReleaseDate = new DateTime(1994, 10, 4), Type = MovieType.TV_SHOW}
                );


            modelBuilder.Entity<Actor>().HasData(
                new Actor() { Id = 1, Name = "Morgan Freeman" },
                new Actor() { Id = 2, Name = "Al Pacino" },
                new Actor() { Id = 3, Name = "Robert De Niro" },
                new Actor() { Id = 4, Name = "Christian Bale" },
                new Actor() { Id = 5, Name = "Gary Oldman" },
                new Actor() { Id = 6, Name = "Harrison Ford" }
                );

            modelBuilder.Entity<ActorInMovie>().HasData(
                new ActorInMovie() { ActorId = 1, MovieId = 1 },
                new ActorInMovie() { ActorId = 2, MovieId = 1 },
                new ActorInMovie() { ActorId = 1, MovieId = 2 },
                new ActorInMovie() { ActorId = 3, MovieId = 3 },
                new ActorInMovie() { ActorId = 4, MovieId = 4 },
                new ActorInMovie() { ActorId = 5, MovieId = 4 },
                new ActorInMovie() { ActorId = 6, MovieId = 5 },
                new ActorInMovie() { ActorId = 1, MovieId = 5 },
                new ActorInMovie() { ActorId = 3, MovieId = 5 },
                new ActorInMovie() { ActorId = 1, MovieId = 6 },
                new ActorInMovie() { ActorId = 2, MovieId = 7 },
                new ActorInMovie() { ActorId = 4, MovieId = 8 },
                new ActorInMovie() { ActorId = 5, MovieId = 9 },
                new ActorInMovie() { ActorId = 1, MovieId = 10 },
                new ActorInMovie() { ActorId = 2, MovieId = 10 },
                new ActorInMovie() { ActorId = 3, MovieId = 10 },
                new ActorInMovie() { ActorId = 4, MovieId = 11 },
                new ActorInMovie() { ActorId = 6, MovieId = 12 },
                new ActorInMovie() { ActorId = 2, MovieId = 13 },
                new ActorInMovie() { ActorId = 5, MovieId = 14 }
                );

            modelBuilder.Entity<Rating>().HasData(
                new Rating() { Id = 1, MovieId = 1, Stars = 5},
                new Rating() { Id = 2, MovieId = 1, Stars = 4},
                new Rating() { Id = 3, MovieId = 1, Stars = 5},
                new Rating() { Id = 4, MovieId = 1, Stars = 4},
                new Rating() { Id = 5, MovieId = 1, Stars = 5},
                new Rating() { Id = 6, MovieId = 2, Stars = 5},
                new Rating() { Id = 7, MovieId = 2, Stars = 4},
                new Rating() { Id = 8, MovieId = 2, Stars = 4},
                new Rating() { Id = 9, MovieId = 3, Stars = 5},
                new Rating() { Id = 10, MovieId = 3, Stars = 5},
                new Rating() { Id = 11, MovieId = 3, Stars = 5},
                new Rating() { Id = 12, MovieId = 3, Stars = 5}
                );
        }
    }
}
