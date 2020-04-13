using System;
using System.Globalization;

namespace BlueScreenSaver
{
    internal class IntoToStringConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intVal = (int)value;

            return intVal.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var strVal = (string)value;

            return int.Parse(strVal);
        }
    }
}
