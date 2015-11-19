using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace BooksSample.Utilities
{
    [ValueConversion(typeof(IEnumerable<string>), typeof(string))]
    public class StringArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<string> names = (IEnumerable<string>)value;
            string param = parameter.ToString();
            return string.Join(param, names);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
