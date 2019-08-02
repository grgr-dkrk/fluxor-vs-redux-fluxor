using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;

namespace fluxor_vs_redux_fluxor.Store
{
  public class RemoveTodoReducer : Reducer<AppState, RemoveTodoAction>
  {
    public override AppState Reduce(AppState state, RemoveTodoAction action)
    {
      var newitems = new List<TodoData>(state.TodoItems);
      newitems.RemoveAll(x => x.Id == action.Id);
      return new AppState(TodoItems: newitems, User: state.User);
    }
  }
}