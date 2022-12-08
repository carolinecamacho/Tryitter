using Tryitter.Models;
using Microsoft.EntityFrameworkCore;

namespace Tryitter.Repository
{
  public class TryitterRepository : ITryitterRepository
  {
    protected readonly TryitterContext _context;
    public TryitterRepository(TryitterContext context)
      {
        _context = context;
      }

    public IEnumerable<User> GetUsers()
      {
        return _context.Users
            .Select(x => new User{
                    UserId = x.UserId,
                    Name = x.Name,
                    Email = x.Email,
                    Password = x.Password,
                    Module = x.Module,
                    Status = x.Status,
                });
        }
  }
}