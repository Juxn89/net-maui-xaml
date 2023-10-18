using Features = maui_xaml.Views.Features;
namespace maui_xaml
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new Features.Shadows();
        }
    }
}