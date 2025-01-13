using Microsoft.EntityFrameworkCore;
using SuperTicTacToe.Models;

namespace SuperTicTacToe.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }  // Represents the "Questions" table in your database.
    }
}
