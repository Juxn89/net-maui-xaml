namespace maui_xaml.Views.Triggers
{
    public class TriggerEventSample : TriggerAction<Button>
    {
        protected override void Invoke(Button sender)
        {
            sender.BackgroundColor = Color.FromArgb("#97ca3f");
            sender.FontSize = 20;
        }
    }
}
