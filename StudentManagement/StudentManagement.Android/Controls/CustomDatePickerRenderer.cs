using StudentManagement.Controls;
using StudentManagement.Droid.Controls;
using StudentManagement.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace StudentManagement.Droid.Controls
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            
            var element = (CustomDatePicker)Element;

            SetFontSize(element.FontSize);
            SetBorder(element.Border);
            SetPlaceholer(element.Placeholder, element.HasPlaceholder);
        }

        private void SetFontSize(double elementFontSize)
        {
            Control.TextSize = (float)elementFontSize;
        }

        private void SetBorder(BorderType elementBorder)
        {
            switch (elementBorder)
            {
                case BorderType.None:
                    Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    break;
            }
        }

        private void SetPlaceholer(string elementPlaceholder, bool elementHasPlaceholder)
        {
            if (elementHasPlaceholder)
            {
                Control.Hint = elementPlaceholder;
                Control.Text = "";
            }
        }
    }
}