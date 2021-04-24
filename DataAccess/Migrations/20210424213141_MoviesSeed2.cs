using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class MoviesSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Morgan Freeman" },
                    { 2, "Al Pacino" },
                    { 3, "Robert De Niro" },
                    { 4, "Christian Bale" },
                    { 5, "Gary Oldman" },
                    { 6, "Harrison Ford" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Forrest Gump");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "Description", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 13, "", "", "The Lord of the Rings: The Two Towers", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "", "", "Star Wars: Episode V - The Empire Strikes Back", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "", "", "Inception", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "Stars" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 12, 3, 5 },
                    { 3, 1, 5 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 2, 5 },
                    { 7, 2, 4 },
                    { 8, 2, 4 },
                    { 9, 3, 5 },
                    { 10, 3, 5 },
                    { 11, 3, 5 },
                    { 2, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "ActorsInMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 12 },
                    { 6, 5 },
                    { 5, 9 },
                    { 5, 4 },
                    { 4, 11 },
                    { 4, 8 },
                    { 4, 4 },
                    { 3, 10 },
                    { 3, 5 },
                    { 3, 3 },
                    { 2, 10 },
                    { 2, 7 },
                    { 2, 1 },
                    { 1, 10 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 2 },
                    { 2, 13 },
                    { 5, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ActorsInMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Fight Club");
        }
    }
}
