using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BedayzMobil.Models;

namespace BedayzMobil.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.ÜyeGirisi:
                        MenuPages.Add(id, new NavigationPage(new Giris()));
                        break;
                    case (int)MenuItemType.Hesabım:
                        MenuPages.Add(id, new NavigationPage(new Hesabım()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }

        }

        public void NavigateTo(ContentPage TargetPage)
        {
            this.Master = TargetPage;
            //this.Title = TargetPage.Title;
            //this.IsPresented = false;
        }
       /* public async void PushPage(MenuItemType menuItemType, ContentPage page)
        {
            if (menuItemType == MenuItemType.ÇıkışYap)
            {
                await ((NavigationPage)((MasterDetailPage)Application.Current.MainPage).Detail).CurrentPage.Navigation.PopAsync();
            }
            else
                await ((NavigationPage)((MasterDetailPage)Application.Current.MainPage).Detail).CurrentPage.Navigation.PushAsync(page);

            if (Device.RuntimePlatform == Device.Android)
                await Task.Delay(100);

            IsPresented = false;
        }*/
    }
}