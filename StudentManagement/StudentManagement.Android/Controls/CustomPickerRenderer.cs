using StudentManagement.Controls;
using StudentManagement.Droid.Controls;
using StudentManagement.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace StudentManagement.Droid.Controls
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            var element = (CustomPicker)Element;

            SetFontSize(element.FontSize);
            SetBorder(element.Border);
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
    }
}