namespace Deliberatio;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AppsDetailPage), typeof(AppsDetailPage));
	}
}
