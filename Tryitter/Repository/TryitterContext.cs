using Microsoft.EntityFrameworkCore;
using Tryitter.Models;

namespace Tryitter.Repository;

public class TryitterContext: DbContext, ITryitterContext
{
  public TryitterContext(DbContextOptions<TryitterContext> options) : base(options) {}
  public DbSet<User> Users { get; set; } = null!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
