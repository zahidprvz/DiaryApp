using Microsoft.EntityFrameworkCore;
using DiaryApp.Models;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Models.DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "My First Diary Entry",
                    Content = "Today I started my new diary app project. I'm excited to learn more about ASP.NET Core and Entity Framework Core!",
                    CreatedOn = new DateTime(2026, 3, 1)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "My Second Diary Entry",
                    Content = "I created the ApplicationDbContext class and added a DbSet for DiaryEntry. Next, I will run the migrations to create the database.",
                    CreatedOn = new DateTime(2026, 3, 1)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "My Third Diary Entry",
                    Content = "I ran the migrations and created the database successfully. Now I can start building the CRUD operations for my diary entries!",
                    CreatedOn = new DateTime(2026, 3, 1)
                }
            );

            // Four steps to create a new table in the database:
            // 1. Create a Model Class
            // 2. Add DB Set
            // 3. add-migration AddDiaryEntryTable
            // 4. update-database
        }
    }
}
