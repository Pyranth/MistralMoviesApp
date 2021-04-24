using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class MoviesSeed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CoverImage", "Description", "Name", "ReleaseDate", "Type" },
                values: new object[,]
                {
                    { 15, "", "", "Planet Earth", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "", "", "Band of Brothers", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "", "", "Breaking Bad", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "", "", "Chernobyl", new DateTime(1994, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
