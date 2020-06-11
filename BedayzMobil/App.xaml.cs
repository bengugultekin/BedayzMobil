using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BedayzMobil.Services;
using BedayzMobil.Views;
using DLToolkit.Forms.Controls;

namespace BedayzMobil
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
