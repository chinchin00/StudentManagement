using System;
using System.Globalization;
using Xamarin.Forms;

namespace StudentManagement.Converters
{
    public class BoolToStringConverter : IValueConverter
    {
        public string TrueValue { get; set; }

        public string FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }

}
