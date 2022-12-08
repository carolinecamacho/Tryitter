using Microsoft.EntityFrameworkCore;
using Tryitter.Models;

namespace Tryitter.Repository 
{
    public interface ITryitterContext
    {
        public DbSet<User> Users { get; set; }
        public int SaveChanges();
    }
}