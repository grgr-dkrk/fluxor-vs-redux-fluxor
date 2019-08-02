using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store.Todo {
  public class RemoveTodoAction : IAction {
    public string Id;
    public RemoveTodoAction(string Id)
    {
      this.Id = Id;
    }
  }
}
