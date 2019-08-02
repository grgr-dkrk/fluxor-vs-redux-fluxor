using Microsoft.AspNetCore.Mvc;
using fluxor_vs_redux_fluxor.Shared;

namespace fluxor_vs_redux_fluxor.Controllers
{
  [Route("api/")]
  public class UserConrtoller : Controller
  {
    private static UserData _User = new UserData();

    static UserConrtoller()
    {
      _User.Id = 0;
      _User.Name = "dkrk0901";
    }

    [HttpGet("getUserData")]
    public UserData GetUserData()
    {
      return _User;
    }

  }
}