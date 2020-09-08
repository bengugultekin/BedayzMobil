using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Settings = BedayzMobil.Helpers.Settings;

namespace BedayzMobil.Converter
{
    public class GirisYapilmadiConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Settings.GirişYapıldı == "true")
            {
                return false;
            }
            return true;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return System.Convert.ToInt32(value);
        }
    }
}
