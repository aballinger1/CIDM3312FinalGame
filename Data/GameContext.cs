using Microsoft.EntityFrameworkCore;
using AnotherNightmare.Models;

namespace AnotherNightmare.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public DbSet<Scene> Scenes { get; set; } = default!;
        public DbSet<Choice> Choices { get; set; } = default!;
    }
}