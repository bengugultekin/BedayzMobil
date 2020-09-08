using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedayzMobil.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BedayzMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hesabım : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }//buradan emin değilim
        List<HomeMenuItem> ACMenuItems;
        public Hesabım()
        {
            InitializeComponent();

            ListViewMenu.SelectedItem = null;
            ACMenuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.ÜyelikBilgileri, Title="Üyelik Bilgilerim" },
                new HomeMenuItem {Id = MenuItemType.Diğer, Title="Adres Bilgilerim" },
                new HomeMenuItem {Id = MenuItemType.Siparişler, Title="Siparişlerim" },
                new HomeMenuItem {Id = MenuItemType.Diğer, Title="Favorilerim" },
                new HomeMenuItem {Id = MenuItemType.Diğer, Title="Mesajlarım" },
                new HomeMenuItem {Id = MenuItemType.Diğer, Title="Şifre Değiştirme" },
                new HomeMenuItem {Id = MenuItemType.ÇıkışYap, Title="Çıkış Yap" }
            };

            ListViewMenu.ItemsSource = ACMenuItems;

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;

                ListViewMenu.SelectedItem = null;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}