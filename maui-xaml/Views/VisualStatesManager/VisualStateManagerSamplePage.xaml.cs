using System.Text.RegularExpressions;

namespace maui_xaml.Views.VisualStatesManager;

public partial class VisualStateManagerSamplePage : ContentPage
{
	public VisualStateManagerSamplePage()
	{
		InitializeComponent();
        GoToState(false);
	}

    private void onTextChanged(object sender, TextChangedEventArgs e)
    {
        string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        bool isValid = Regex.IsMatch(e.NewTextValue, expresion);
    }

    void GoToState(bool isValid) {
        string vState = isValid ? "Correct" : "Incorrect";
        VisualStateManager.GoToState(EntryEmail, vState);
    }
}