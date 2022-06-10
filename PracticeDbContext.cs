using Microsoft.EntityFrameworkCore;
using PracticeExercise1.Models;

namespace PracticeExercise1
{
    public class PracticeDbContext : DbContext
    {
        public PracticeDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Connection String");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
