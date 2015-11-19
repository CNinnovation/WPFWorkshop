using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiBindingSample
{
    public class NameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string retString = string.Empty;
            string[] names = values.Cast<string>().ToArray();
            switch (parameter.ToString())
            {
                case "FirstLast":
                    retString = $"{names[0]} {names[1]}";
                    break;
                case "LastFirst":
                    retString = $"{names[1]}, {names[0]}";
                    break;
                default:
                    break;
            }

            return retString;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
