using System;
using BedayzMobil.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BedayzMobil.Helpers;


namespace BedayzMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UyeOl : ContentPage
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private async void KayitOl_Clicked(object sender, EventArgs e)
        {
           /* var isSuccess = await restAPIForAccounts.Register(EmailLBL.Text,
            PasswordLBL.Text, NameLBL.Text, LastNameLBL.Text, UserNameLBL.Text);
            if (isSuccess)
            {
                Mesaj.Text = "Kayıt başarılı!";
                Settings.Email = EmailLBL.Text;
                Settings.Password = PasswordLBL.Text;
                await Navigation.PushAsync(new Giris());
            }
            else
                Mesaj.Text = "Kayıt başarısız, lütfen tekrar deneyin! ";*/
        }
    }
}