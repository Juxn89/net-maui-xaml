using maui_xaml.Views.Behaviors;

namespace maui_xaml
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new BehaviorSamplePage();
        }
    }
}