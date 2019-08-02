using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;

namespace fluxor_vs_redux_fluxor.Store.Todo
{
  public class RemoveTodoReducer : Reducer<TodoState, RemoveTodoAction>
  {
    public override TodoState Reduce(TodoState state, RemoveTodoAction action)
    {
      var newitems = new List<TodoData>(state.TodoItems);
      newitems.RemoveAll(x => x.Id == action.Id);
      return new TodoState(TodoItems: newitems);
    }
  }
}