using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store.Todo {
  public class AddTodoAction {
    public string TaskText;
    public AddTodoAction(string text)
    {
      this.TaskText = text;
    }
  }
}
