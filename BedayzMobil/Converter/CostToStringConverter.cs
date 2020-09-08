using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Globalization;

namespace BedayzMobil.Converter
{
    public class CostToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format("{0:#,0.####}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return System.Convert.ToDouble(value);
        }
    }
}
