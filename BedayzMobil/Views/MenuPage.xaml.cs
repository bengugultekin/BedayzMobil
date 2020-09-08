using BedayzMobil.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Settings = BedayzMobil.Helpers.Settings;
using BedayzMobil.Helpers;

namespace BedayzMobil.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Anasayfa" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Hoodie, Title="Hoodie" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                ((ListView)sender).SelectedItem = null;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private async void ÜyeOlButton_Clicked(object sender, EventArgs e)
        {
            await RootPage.NavigateFromMenu(Convert.ToInt32(MenuItemType.ÜyeGirisi));
        }

        private async void Hesabım_Clicked(object sender, EventArgs e)
        {
            await RootPage.NavigateFromMenu(Convert.ToInt32(MenuItemType.Hesabım));
        }
    }
}