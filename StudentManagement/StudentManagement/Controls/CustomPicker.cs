using StudentManagement.Enums;
using Xamarin.Forms;

namespace StudentManagement.Controls
{
    public class CustomPicker : Picker
    {
        #region FontSize
        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(CustomPicker),
                12d,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomPicker)bindable;
                    control.FontSize = (double)newValue;
                });

        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }
        #endregion

        #region Border

        public static readonly BindableProperty BorderProperty =
            BindableProperty.Create(
                nameof(Border),
                typeof(BorderType),
                typeof(CustomPicker),
                BorderType.None,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomPicker)bindable;
                    control.Border = (BorderType)newValue;
                });

        public BorderType Border
        {
            get => (BorderType)GetValue(BorderProperty);
            set => SetValue(BorderProperty, value);
        }

        #endregion
    }
}
