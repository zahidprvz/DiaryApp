using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { 1, "Today I started my new diary app project. I'm excited to learn more about ASP.NET Core and Entity Framework Core!", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My First Diary Entry" },
                    { 2, "I created the ApplicationDbContext class and added a DbSet for DiaryEntry. Next, I will run the migrations to create the database.", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Second Diary Entry" },
                    { 3, "I ran the migrations and created the database successfully. Now I can start building the CRUD operations for my diary entries!", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Third Diary Entry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
