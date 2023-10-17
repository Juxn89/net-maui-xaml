using maui_xaml.Views.BindingsSample;

namespace maui_xaml
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new BindingSamplePage();
            var navPage = new NavigationPage(new BindingSamplePage());
            Navigation = navPage.Navigation;
            MainPage = navPage;
        }
    }
}