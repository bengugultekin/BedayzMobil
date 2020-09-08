using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BedayzMobil.Helpers;
using BedayzMobil.Models;
using Xamarin.Forms;
using Settings = BedayzMobil.Helpers.Settings;

namespace BedayzMobil.Converter
{
    public class GirisYapildiConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            UserSettings userSettings = new UserSettings();
            if (userSettings.GirisYapıldı == "true")
            {

                return true;
            }
            return false;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return System.Convert.ToInt32(value);
        }
    }
}
