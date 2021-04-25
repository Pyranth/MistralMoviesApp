﻿// <auto-generated />
using System;
using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    partial class MoviesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Morgan Freeman"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Al Pacino"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Robert De Niro"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Christian Bale"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Gary Oldman"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Harrison Ford"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.ActorInMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorsInMovies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 11
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 12
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 13
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 14
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverImage = "image1.png",
                            Description = "",
                            Name = "The Shawshank Redemption",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            CoverImage = "image2.png",
                            Description = "",
                            Name = "The Godfather",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            CoverImage = "",
                            Description = "",
                            Name = "The Godfather: Part II",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            CoverImage = "",
                            Description = "",
                            Name = "The Dark Knight",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 5,
                            CoverImage = "",
                            Description = "",
                            Name = "12 Angry Men",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            CoverImage = "",
                            Description = "",
                            Name = "Schindler's List",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 7,
                            CoverImage = "",
                            Description = "",
                            Name = "The Lord of the Rings: The Return of the King",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            CoverImage = "",
                            Description = "",
                            Name = "Pulp Fiction",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 9,
                            CoverImage = "",
                            Description = "",
                            Name = "The Good, the Bad and the Ugly",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 10,
                            CoverImage = "",
                            Description = "",
                            Name = "The Lord of the Rings: The Fellowship of the Ring",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 11,
                            CoverImage = "",
                            Description = "",
                            Name = "Forrest Gump",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 12,
                            CoverImage = "",
                            Description = "",
                            Name = "Inception",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 13,
                            CoverImage = "",
                            Description = "",
                            Name = "The Lord of the Rings: The Two Towers",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 14,
                            CoverImage = "",
                            Description = "",
                            Name = "Star Wars: Episode V - The Empire Strikes Back",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 15,
                            CoverImage = "",
                            Description = "",
                            Name = "Planet Earth",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            Id = 16,
                            CoverImage = "",
                            Description = "",
                            Name = "Band of Brothers",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            Id = 17,
                            CoverImage = "",
                            Description = "",
                            Name = "Breaking Bad",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            Id = 18,
                            CoverImage = "",
                            Description = "",
                            Name = "Chernobyl",
                            ReleaseDate = new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            Stars = 5
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 1,
                            Stars = 4
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 1,
                            Stars = 5
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 1,
                            Stars = 4
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 1,
                            Stars = 5
                        },
                        new
                        {
                            Id = 6,
                            MovieId = 2,
                            Stars = 5
                        },
                        new
                        {
                            Id = 7,
                            MovieId = 2,
                            Stars = 4
                        },
                        new
                        {
                            Id = 8,
                            MovieId = 2,
                            Stars = 4
                        },
                        new
                        {
                            Id = 9,
                            MovieId = 3,
                            Stars = 5
                        },
                        new
                        {
                            Id = 10,
                            MovieId = 3,
                            Stars = 5
                        },
                        new
                        {
                            Id = 11,
                            MovieId = 3,
                            Stars = 5
                        },
                        new
                        {
                            Id = 12,
                            MovieId = 3,
                            Stars = 5
                        });
                });

            modelBuilder.Entity("DataAccess.Models.ActorInMovie", b =>
                {
                    b.HasOne("DataAccess.Models.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Movie", "Movie")
                        .WithMany("Cast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Rating", b =>
                {
                    b.HasOne("DataAccess.Models.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
