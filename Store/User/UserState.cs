using System;
using fluxor_vs_redux_fluxor.Shared;

namespace fluxor_vs_redux_fluxor.Store.User {
  public class UserState {
    public UserData Data { get; private set; }
    public UserState() {
      this.Data = null;
    }
    public UserState(UserData Data) {
      this.Data = Data;
    }
  }
}