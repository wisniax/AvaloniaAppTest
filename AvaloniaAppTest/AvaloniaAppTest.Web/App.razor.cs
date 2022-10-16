using Avalonia.Web.Blazor;

namespace AvaloniaAppTest.Web
{
	public partial class App
	{
		protected override void OnParametersSet()
		{
			base.OnParametersSet();

			WebAppBuilder.Configure<AvaloniaAppTest.App>()
				.SetupWithSingleViewLifetime();
		}
	}
}