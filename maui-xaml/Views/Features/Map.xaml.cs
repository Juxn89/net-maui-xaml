namespace maui_xaml.Views.Features;

public partial class MapAPI : ContentPage
{
	public MapAPI()
	{
		InitializeComponent();
		LoadMap();
	}
	public async void LoadMap() {
		var location = new Location(28.3771857, -81.5733149,17);
		var options = new MapLaunchOptions { Name = "Disney World!" };
		await Map.OpenAsync(location, options);
	}
}