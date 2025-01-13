using Microsoft.EntityFrameworkCore;
using SuperTicTacToe.Models;

namespace SuperTicTacToe.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }

        // Override the default table naming conventions (use PascalCase)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Question>()
                .ToTable("Questions"); // Make sure EF uses the "Questions" table name (with uppercase Q)
        }
    }
}
