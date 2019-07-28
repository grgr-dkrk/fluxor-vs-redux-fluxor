using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;

namespace fluxor_vs_redux_fluxor.Store
{
  public class ToggleDoneTaskReducer : Reducer<AppState, ToggleDoneTaskAction>
  {
    public override AppState Reduce(AppState state, ToggleDoneTaskAction action)
    {
      var newitems = new List<TodoData>(state.TodoItems);
      newitems.ForEach(data => {
        if (data.Id == action.Id) {
          data.IsDone = data.IsDone ? false : true;
        }
      });
      return new AppState(TodoItems: newitems);
    }
  }
}