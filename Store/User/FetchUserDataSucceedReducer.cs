using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store.User
{
  public class FetchUserDataSucceedReducer : Reducer<UserState, FetchUserDataSucceedAction>
  {
    public override UserState Reduce(UserState state, FetchUserDataSucceedAction action)
    {
      return new UserState(
        Data: action.UserData
      );
    }
  }
}