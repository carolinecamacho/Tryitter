using Tryitter.Models;

namespace Tryitter.Repository
{
    public interface ITryitterRepository
    {
      IEnumerable<User> GetUsers();
    }
}