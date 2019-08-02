using System;
using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;

namespace fluxor_vs_redux_fluxor.Store
{
  public class AddTodoReducer : Reducer<AppState, AddTodoAction>
  {
    public override AppState Reduce(AppState state, AddTodoAction action)
    {
      var newitems = new List<TodoData>(state.TodoItems);
      var guid = Guid.NewGuid();
      newitems.Add(new TodoData() { Id = guid.ToString(), TaskText = action.TaskText, IsDone = false });
      return new AppState(TodoItems: newitems, User: state.User);
    }
  }
}