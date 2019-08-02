using Blazor.Fluxor;

namespace fluxor_vs_redux_fluxor.Store.User
{
	public class UserFeature : Feature<UserState>
	{
		public override string GetName() => "User";
		protected override UserState GetInitialState() => new UserState();
	}
}