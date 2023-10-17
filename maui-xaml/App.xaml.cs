using maui_xaml.Views.Features;

namespace maui_xaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MapAPI();
        }
    }
}