using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store
{
  public class FetchUserDataSucceedReducer : Reducer<AppState, FetchUserDataSucceedAction>
  {
    public override AppState Reduce(AppState state, FetchUserDataSucceedAction action)
    {
      return new AppState(
        TodoItems: state.TodoItems,
        User: action.UserData
      );
    }
  }
}