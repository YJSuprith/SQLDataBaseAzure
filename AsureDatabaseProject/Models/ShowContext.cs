using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsureDatabaseProject.Models
{
    public class ShowContext : DbContext
    {
        public ShowContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 101,
                Name = "X-man",
                Description = "Sci-Fi",
                Duration = 122.2f
            });
        }
    }
}
