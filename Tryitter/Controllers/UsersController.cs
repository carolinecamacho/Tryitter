using Microsoft.AspNetCore.Mvc;
using Tryitter.Repository;
using Tryitter.Models;

namespace Tryitter.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TryitterController : ControllerBase
  {
    private readonly ITryitterRepository _repository;
    public TryitterController(ITryitterRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public IEnumerable<User> GetAllUsers()
    {
      return (IEnumerable<User>)Ok(_repository.GetUsers());
    } 
  }
}