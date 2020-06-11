using BedayzMobil.Models;
using BedayzMobil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BedayzMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        ÜrünModel ÜrünModel; 
        public Anasayfa()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
                "https://www.bedayz.com/Uploads/Slider/quarantine-30.jpg?t=20200516182750",
                "https://www.bedayz.com/Uploads/Slider/bandana-29.jpg?t=20200427155138",
                "https://www.bedayz.com/Uploads/Slider/hope-28.jpg?t=20200421183821",
                "https://www.bedayz.com/Uploads/Slider/munchies-sweat-24.jpg?t=20200302184902",
                "https://www.bedayz.com/Uploads/Slider/key-chains-23.jpg?t=20200120215546",
                "https://www.bedayz.com/Uploads/Slider/savage-21.jpg?t=20200302185000"
            };
            FırsatÜrünleriCarousel.ItemsSource = CarouselItems;
            ÜrünModel = new ÜrünModel(this);
            //BindingContext = ÜrünModel;
            ÖneÇıkanÜrünlerFLV.FlowItemsSource = new ÜrünModel(this).GetItems(2);
            FırsatÜrünleriCarousel.ItemsSource = CarouselItems;
            
        }

        private void ÜrünTapped(object sender, ItemTappedEventArgs e)
        {
            /*var content = e.Item as ÜrünItem;
            await Navigation.PushAsync(new ÜrünSayfasi(content));*/
        }
    }
    
}
