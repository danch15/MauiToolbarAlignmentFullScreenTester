namespace ToolbarAlignmentTester;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartupPage()) { BarBackgroundColor = Colors.LightSkyBlue, BarTextColor = Colors.Black};
	}
}
