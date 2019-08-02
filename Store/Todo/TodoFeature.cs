using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store.Todo
{
	public class TodoFeature : Feature<TodoState>
	{
		public override string GetName() => "Todo";
		protected override TodoState GetInitialState() => new TodoState();
	}
}