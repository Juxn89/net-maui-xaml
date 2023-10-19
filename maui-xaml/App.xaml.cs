using maui_xaml.Views.Triggers;

namespace maui_xaml
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new TriggerMultiSamplePage();
        }
    }
}