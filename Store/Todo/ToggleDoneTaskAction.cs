using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store.Todo {
  public class ToggleDoneTaskAction : IAction {
    public string Id;
    public ToggleDoneTaskAction(string Id)
    {
      this.Id = Id;
    }
  }
}
