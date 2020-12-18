using StudentManagement.Controls;
using StudentManagement.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace StudentManagement.Droid.Controls
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            var control = (Android.Widget.Button)Control;
            var element = (CustomButton)Element;

            SetAllCaps(ref control, element.AllCaps);
        }

        private void SetAllCaps(ref Android.Widget.Button control, bool elementAllCaps)
        {
            control.SetAllCaps(elementAllCaps);
        }
    }
}