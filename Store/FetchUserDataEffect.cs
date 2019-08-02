using Blazor.Fluxor;
using fluxor_vs_redux_fluxor.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;

using System.Threading.Tasks;

namespace fluxor_vs_redux_fluxor.Store
{
  public class FetchUserDataEffect : Effect<FetchUserDataAction>
  {
    private readonly IHttpClientFactory HttpClient;

    public FetchUserDataEffect(IHttpClientFactory httpClient)
    {
      HttpClient = httpClient;
    }

    protected async override Task HandleAsync(FetchUserDataAction action, IDispatcher dispatcher) {
      UserData userData = new UserData();
      Console.WriteLine("fetchAction");
      try {
        var client = HttpClient.CreateClient();
        await Task.Delay(2000);
        userData.Id = 0;
        userData.Name = "dkrk0901";
        var complete = new FetchUserDataSucceedAction(userData);
        dispatcher.Dispatch(complete);
      }
      catch(Exception e) {
        Console.WriteLine(e);
        return;
      }
    }
  }
}