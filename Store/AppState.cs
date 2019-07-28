using System;
using fluxor_vs_redux_fluxor.Shared;
using System.Collections.Generic;
using System.Linq;

namespace fluxor_vs_redux_fluxor.Store {
  public class AppState {
    public TodoData[] TodoItems { get; private set; }

    public AppState() {
      this.TodoItems = Array.Empty<TodoData>();
    }
    public AppState(IEnumerable<TodoData> TodoItems) {
      this.TodoItems = TodoItems?.ToArray() ?? Array.Empty<TodoData>();
    }
  }
}