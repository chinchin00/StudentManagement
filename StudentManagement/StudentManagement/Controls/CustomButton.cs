using StudentManagement.Enums;
using Xamarin.Forms;

namespace StudentManagement.Controls
{
    public class CustomButton : Button
    {
        #region AllCaps

        public static readonly BindableProperty AllCapsProperty =
            BindableProperty.Create(
                nameof(AllCaps),
                typeof(bool),
                typeof(CustomButton),
                false,
                propertyChanged: (bindable, value, newValue) =>
                {
                    var control = (CustomButton)bindable;
                    control.AllCaps = (bool)newValue;
                });

        public bool AllCaps
        {
            get => (bool)GetValue(AllCapsProperty);
            set => SetValue(AllCapsProperty, value);
        }

        #endregion
    }
}
