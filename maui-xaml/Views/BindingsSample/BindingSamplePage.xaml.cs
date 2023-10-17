namespace maui_xaml.Views.BindingsSample;

public partial class BindingSamplePage : ContentPage
{
	public BindingSamplePage()
	{
		InitializeComponent();
		BindingContext = new TeacherViewModel();
    }
}