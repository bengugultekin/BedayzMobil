using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BedayzMobil.Data;
using BedayzMobil.Models;
using BedayzMobil.Services;
using BedayzMobil.Views;
using Xamarin.Forms;
using static BedayzMobil.Services.RestAPIForProducts;


namespace BedayzMobil.ViewModels
{
    public class ÜrünModel : BindableObject
    {
        private Page Page;
        List<Product> Products = new List<Product>();
        RestAPIForProducts RestAPI;
        public ÜrünModel(Page mainPage)
        {
            this.Page = mainPage;
            RestAPI = new RestAPIForProducts();
            Products = GetAllItems();
        }
        public Product FindÜrünItemWithName(string Name)
        {
            Product Ürün = new Product();
            foreach (var item in Products)
            {
                if (Name == item.Name)
                {
                    Ürün = item;
                    break;
                }
            }
            return Ürün;
        }
        public Product FindÜrünItemWithId(string Id)
        {
            Product Ürün = new Product();
            foreach (Product item in Products)
            {
                if (Id == item.Id.ToString())
                {
                    Ürün = item;
                    break;
                }
            }
            return Ürün;
        }
        public List<Product> GetItems(int numberOfItem)
        {
            List<Product> Items = new List<Product>();
            foreach (Product item in Products)
            {
                Items.Add(item);
                if (Items.Count == numberOfItem)
                {
                    break;
                }

            }

            return Items;
        }
        public List<Product> GetAllItemsNonCallApi()
        {
            return Products;
        }
        public List<Product> GetAllItems()
        {

            return RestAPI.GetProducts();
        }
        public List<Product> GetProductsWithDetailWord(string word)
        {
            List<Product> Ürünler = new List<Product>();
            foreach (var item in Products)
            {
                if (item.Info.ToLower().Contains(word.ToLower()))
                {
                    Ürünler.Add(item);
                }
            }
            return Ürünler;
        }

        public List<Product> FiyataGöreFiltrele(string minimum, string maksimum)
        {
            int min = 0;
            int max = 0;
            if (string.IsNullOrWhiteSpace(minimum))
            {
                min = 0;
            }
            else min = Convert.ToInt32(minimum);
            if (string.IsNullOrWhiteSpace(maksimum))
            {
                max = 100000;
            }
            else max = Convert.ToInt32(maksimum);

            var products = GetAllItemsNonCallApi();
            products = products.Where(c => c.Cost >= min).ToList();
            products = products.Where(c => c.Cost <= max).ToList();
            return products;
        }
        public List<Product> Arama(string word)
        {
            string[] substrings = word.Split(' ');
            if (string.IsNullOrWhiteSpace(word))
                return null;
            else
            {
                var products = GetAllItemsNonCallApi();
                foreach (var item in substrings)
                {
                    products = products.Where(c => c.Info.ToLower().Contains(item.ToLower())).ToList();
                }
                return products;
            }

        }
    }
}
