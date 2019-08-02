using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;

namespace fluxor_vs_redux_fluxor.Store
{
  public class FetchUserDataSucceedAction : IAction
  {
    public UserData UserData { get; private set; }

    public FetchUserDataSucceedAction(UserData userData)
    {
      this.UserData = userData;
    }
  }
}