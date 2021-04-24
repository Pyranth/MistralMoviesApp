using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class MoviesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "Description", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "", "", "The Shawshank Redemption", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", "", "The Godfather", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", "", "The Godfather: Part II", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", "", "The Dark Knight", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", "", "12 Angry Men", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "", "", "Schindler's List", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "", "", "The Lord of the Rings: The Return of the King", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "", "", "Pulp Fiction", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "", "", "The Good, the Bad and the Ugly", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "", "", "The Lord of the Rings: The Fellowship of the Ring", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "", "", "Fight Club", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
