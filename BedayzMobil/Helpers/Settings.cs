using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BedayzMobil.Models;
using BedayzMobil.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BedayzMobil.Helpers
{
    public class Settings
    {

        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        /* #region Setting Constants

         private const string SettingsKey = "settings_key";
         private static readonly string SettingsDefault = string.Empty;
         private const string _ApiUrl = "https://bedayzapi.azurewebsites.net/";

         #endregion

         public static string ApiUrl
         {
             get
             {
                 return AppSettings.GetValueOrDefault("ApiUrl", _ApiUrl);
             }
         }*/
        public static string Email
        {
            get
            {
                return AppSettings.GetValueOrDefault("Email", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Email", value);
            }
        }
        public static string Password
        {
            get
            {
                return AppSettings.GetValueOrDefault("Password", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Password", value);
            }
        }
        public static string Name
        {
            get
            {
                return AppSettings.GetValueOrDefault("Name", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Name", value);
            }
        }
        public static string LastName
        {
            get
            {
                return AppSettings.GetValueOrDefault("LastName", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("LastName", value);
            }
        }
        public static string UserName
        {
            get
            {
                return AppSettings.GetValueOrDefault("UserName", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("UserName", value);
            }
        }
        public static string UserId
        {
            get
            {
                return AppSettings.GetValueOrDefault("UserId", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("UserId", value);
            }
        }
        public static string AccessToken
        {
            get
            {
                return AppSettings.GetValueOrDefault("AccessToken", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("AccessToken", value);
            }
        }
        public static string SepetimJson
        {
            get
            {
                return AppSettings.GetValueOrDefault("SepetimJson", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("SepetimJson", value);
            }
        }
        public static string GirişYapıldı
        {
            get
            {
                return AppSettings.GetValueOrDefault("GirişYapıldı", "false");
            }
            set
            {
                AppSettings.AddOrUpdateValue("GirişYapıldı", value);
                ((MainPage)Application.Current.MainPage).NavigateTo(new Anasayfa());
               // NotifyStaticPropertyChanged();
            }
        }
        // public static event PropertyChangedEventHandler StaticPropertyChanged;

        /* private static void NotifyStaticPropertyChanged([CallerMemberName] string name = null)
         {
             StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(name));
         }*/

    }
}
