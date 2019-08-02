using System;
using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;

namespace fluxor_vs_redux_fluxor.Store.Todo
{
  public class AddTodoReducer : Reducer<TodoState, AddTodoAction>
  {
    public override TodoState Reduce(TodoState state, AddTodoAction action)
    {
      var newitems = new List<TodoData>(state.TodoItems);
      var guid = Guid.NewGuid();
      newitems.Add(new TodoData() { Id = guid.ToString(), TaskText = action.TaskText, IsDone = false });
      return new TodoState(TodoItems: newitems);
    }
  }
}