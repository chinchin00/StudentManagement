using StudentManagement.Enums;
using Xamarin.Forms;

namespace StudentManagement.Controls
{
    public class CustomDatePicker : DatePicker
    {
        #region FontSize
        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(CustomDatePicker),
                12d,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomDatePicker)bindable;
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
                typeof(CustomDatePicker),
                BorderType.None,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomDatePicker)bindable;
                    control.Border = (BorderType)newValue;
                });

        public BorderType Border
        {
            get => (BorderType)GetValue(BorderProperty);
            set => SetValue(BorderProperty, value);
        }

        #endregion
        
        #region Placeholder

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create(
                nameof(Placeholder),
                typeof(string),
                typeof(CustomDatePicker),
                "",
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomDatePicker)bindable;
                    control.Placeholder = (string)newValue;
                });

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        #endregion

        #region HasPlaceholder

        public static readonly BindableProperty HasPlaceholderProperty =
            BindableProperty.Create(
                nameof(HasPlaceholder),
                typeof(bool),
                typeof(CustomDatePicker),
                false,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomDatePicker)bindable;
                    control.HasPlaceholder = (bool)newValue;
                });

        public bool HasPlaceholder
        {
            get => (bool)GetValue(HasPlaceholderProperty);
            set => SetValue(HasPlaceholderProperty, value);
        }

        #endregion

        #region PlaceholderColor

        public static readonly BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(
                nameof(PlaceholderColor),
                typeof(Color),
                typeof(CustomDatePicker),
                Color.Gray,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomDatePicker)bindable;
                    control.PlaceholderColor = (Color)newValue;
                });

        public Color PlaceholderColor
        {
            get => (Color)GetValue(PlaceholderColorProperty);
            set => SetValue(PlaceholderColorProperty, value);
        }

        #endregion
    }
}
