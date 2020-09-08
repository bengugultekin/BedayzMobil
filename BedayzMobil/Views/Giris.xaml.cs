using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedayzMobil.Helpers;
using BedayzMobil.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BedayzMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Giris : ContentPage
    {
        public Giris()
        {
            InitializeComponent();
            Email.Text = Settings.Email;
            Sifre.Text = Settings.Password;
        }

        private async void KayıtOl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UyeOl());
        }

        private async void GirisYap_Clicked(object sender, EventArgs e)
        {
            RestAPIForAccounts restAPIForAccounts = new RestAPIForAccounts();

            var accesToken = await restAPIForAccounts.LoginAsync(Email.Text, Sifre.Text);
            Settings.AccessToken = accesToken;
            if (Settings.GirişYapıldı == "true")
            {
                Settings.Email = Email.Text;
                restAPIForAccounts.GetUserInfo(Settings.Email);
                Settings.Password = Sifre.Text;
                await Navigation.PopToRootAsync();
            }
        }
    }
}