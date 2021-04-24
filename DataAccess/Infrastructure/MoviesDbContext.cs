using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Infrastructure
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorInMovie> ActorsInMovies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Create composide primary key
            modelBuilder.Entity<ActorInMovie>()
                .HasKey(key => new { key.ActorId, key.MovieId });

            // Many to many relationship between Actor and Movie
            modelBuilder.Entity<ActorInMovie>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.Movies)
                .HasForeignKey(am => am.ActorId);

            modelBuilder.Entity<ActorInMovie>()
                .HasOne(am => am.Movie)
                .WithMany(a => a.Cast)
                .HasForeignKey(am => am.MovieId);

            // One to many relationship between Rating and Movie
            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(r => r.MovieId);
        }
    }
}
 