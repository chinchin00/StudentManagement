using System.ComponentModel;
using Android.Widget;
using StudentManagement.Controls;
using StudentManagement.Droid.Controls;
using StudentManagement.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace StudentManagement.Droid.Controls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var control = (EditText)Control;
            var element = (CustomEntry)Element;

            SetBorder(ref control, element.Border);
        }

        private void SetBorder(ref EditText control, BorderType borderType)
        {
            switch (borderType)
            {
                case BorderType.None:
                    control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    break;
            }
        }
    }
}