using System;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;
using System.Linq;

namespace fluxor_vs_redux_fluxor.Store.Todo {
  public class TodoState {
    public TodoData[] TodoItems { get; private set; }
    public TodoState() {
      this.TodoItems = Array.Empty<TodoData>();
    }
    public TodoState(IEnumerable<TodoData> TodoItems) {
      this.TodoItems = TodoItems?.ToArray() ?? Array.Empty<TodoData>();
    }
  }
}