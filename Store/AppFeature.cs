using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store
{
	public class AppFeature : Feature<AppState>
	{
		public override string GetName() => "App";
		protected override AppState GetInitialState() => new AppState();
	}
}