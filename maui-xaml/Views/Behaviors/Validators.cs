using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace maui_xaml.Views.Behaviors
{
    public class NumberValidator : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args) {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.FromArgb("#000000") : Color.FromArgb("#FF0000");
            ((Entry)sender).BackgroundColor = isValid ? Color.FromArgb("#FFFFFF") : Color.FromArgb("#FBC5D0");
        }
    }

    public class TextValidator : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(args.NewTextValue);
            ((Entry)sender).TextColor = isValid ? Color.FromArgb("#FF0000") : Color.FromArgb("#000000");
            ((Entry)sender).BackgroundColor = isValid ? Color.FromArgb("#FBC5D0") : Color.FromArgb("#FFFFFF");
        }
    }
}
