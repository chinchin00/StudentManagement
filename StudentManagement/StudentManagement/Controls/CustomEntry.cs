using StudentManagement.Enums;
using Xamarin.Forms;

namespace StudentManagement.Controls
{
    public class CustomEntry : Entry
    {
        #region Border

        public static readonly BindableProperty BorderProperty =
            BindableProperty.Create(
                nameof(Border),
                typeof(BorderType),
                typeof(CustomEntry),
                BorderType.None,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomEntry) bindable;
                    control.Border = (BorderType) newValue;
                });

        public BorderType Border
        {
            get => (BorderType)GetValue(BorderProperty);
            set => SetValue(BorderProperty, value);
        }

        #endregion
    }
}
