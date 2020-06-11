using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using BedayzMobil.Models;
using BedayzMobil.Data;

namespace BedayzMobil.ViewModels
{
    public class ÜrünModel : BindableObject
    {
        private Page Page;

        RestAPI RestAPI;

        public ÜrünModel(Page mainPage)
        {
            this.Page = mainPage;
            RestAPI = new RestAPI();
            //AddItems();
        }

       /* private void AddItems()
        {
            for (int i = 0; i < 20; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/red-munchies-oversize-t-shirt-d1b2.jpg",
                    Ürünİsmi = string.Format("Ürünİsmi {0}", i),
                    ÜrünDetayı = string.Format("ÜrünDetayı {0}", i),
                    ÜrünFiyatı = string.Format("ÜrünFiyatı {0}", i)
                };
                Items.Add(ürünItem);
            }
            
        }*/
       public ÜrünItem FindÜrünItemWithName(string Name)
        {
            ÜrünItem ürünItem = new ÜrünItem();
            foreach (var Item in RestAPI.GetProducts())
            {
                if (Name == Item.Name)
                    ürünItem = new ÜrünItem()
                    {
                        ImageSource = Item.ImageUrl,
                        Ürünİsmi = Item.Name,
                        ÜrünDetayı = Item.Info,
                        ÜrünFiyatı = Item.Cost.ToString()
                    };
                break;
            }
            return ürünItem;
        }

        public ObservableCollection<ÜrünItem> GetItems(int numberOfItem)
        {
            ObservableCollection<ÜrünItem> Items = new ObservableCollection<ÜrünItem>();
            foreach(var Item in RestAPI.GetProducts())
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = Item.ImageUrl,
                    Ürünİsmi = Item.Name,
                    ÜrünDetayı = Item.Info,
                    ÜrünFiyatı = Item.Cost.ToString()
                };
                Items.Add(ürünItem);
                if(Items.Count == numberOfItem)
                {
                    break;
                }
            }
            return Items;
        }

        public ObservableCollection<ÜrünItem> GetAllItems()
        {
            ObservableCollection<ÜrünItem> Items = new ObservableCollection<ÜrünItem>();
            foreach (var Item in RestAPI.GetProducts())
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = Item.ImageUrl,
                    Ürünİsmi = Item.Name,
                    ÜrünDetayı = Item.Info,
                    ÜrünFiyatı = Item.Cost.ToString()
                };
                Items.Add(ürünItem);
                
            }
            return Items;
        }
        

       /* private ObservableCollection<ÜrünItem> _items = new ObservableCollection<ÜrünItem>();
        public ObservableCollection<ÜrünItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }*/

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}
