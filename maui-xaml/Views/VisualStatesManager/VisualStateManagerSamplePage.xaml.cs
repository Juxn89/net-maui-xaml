using System.Text.RegularExpressions;

namespace maui_xaml.Views.VisualStatesManager;

public partial class VisualStateManagerSamplePage : ContentPage
{
	public VisualStateManagerSamplePage()
	{
		InitializeComponent();
	}

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        bool isValid = Regex.IsMatch(e.NewTextValue, expresion);
        GoToState(isValid);
    }

    void GoToState(bool isValid) {
        string vState = isValid ? "Correct" : "Incorrect";
        VisualStateManager.GoToState(EntryEmail, vState);
    }
}