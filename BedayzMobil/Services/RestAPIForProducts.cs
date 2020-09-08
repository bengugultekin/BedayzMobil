using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using BedayzMobil.Models;
using Xamarin.Forms;
using Settings = BedayzMobil.Helpers.Settings;

namespace BedayzMobil.Services
{
    public class RestAPIForProducts
    {
        private string _ApiUrl = "https://beydayzapi.azurewebsites.net/";
        HttpClient client;
        HttpResponseMessage response;
        public List<Product> Products = new List<Product>();
        public List<Category> Categories = new List<Category>();
        public List<ImageModel> ImageModels = new List<ImageModel>();

        public RestAPIForProducts()
        {
            

            client = new HttpClient()
            {
                BaseAddress = new Uri(_ApiUrl)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            GetData();
        }

        public List<Product> GetProducts()
        {
            response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                Products = items as List<Product>;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Hata!", "Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase, "Tamam");
            }
            foreach (Product item in Products)
            {
                foreach (ImageModel item2 in ImageModels)
                {
                    if (item2.ProductId == item.Id)
                    {
                        item.ImageSource = item2.Url;
                        break;
                    }
                }
            }
            return Products;
        }

        public List<Category> GetCategories()
        {
            

            response = client.GetAsync("api/categories").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Category>>().Result;
                Categories = items as List<Category>;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Hata!", "Error Code" +
               response.StatusCode + " : Message - " + response.ReasonPhrase, "Tamam");
            }
            return Categories;
        }

        public List<ImageModel> GetImageModels()
        {
            // This disables the SSL certificate validity check.
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };


            /* response = client.GetAsync("api/images").Result;
             if (response.IsSuccessStatusCode)
             {
                 var items = response.Content.ReadAsAsync<IEnumerable<ImageModel>>().Result;
                 ImageModels = items as List<ImageModel>;

             }
             else
             {
                 Application.Current.MainPage.DisplayAlert("Hata!", "Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase, "Tamam");
             }*/

            List<string> Image = new List<string>()
            {
                "https://www.bedayz.com/Uploads/UrunResimleri/thumb/gold-vintage-kolye-de93.jpg",
                "https://www.bedayz.com/silver-vintage-kolye"
            };

            return ImageModels;
        }

        private void GetData()
        {

            GetImageModels();
            GetCategories();
            GetProducts();
        }
        /// <summary>
        /// Aşağıda Apide var olan modelleri birebir aldık, Benim Image için fazladan bir kontrollerim vardı
        /// Onu producta birleştirmek için fazladan bir işlem yaptım,
        /// Ürünün görüntülerken sadece bir image kullanacağım için resim için bir ImageUrl yaptım eğer isterseniz side resimler birden
        /// fazla ise string listesi yazın.
        /// </summary>

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Product> Products { get; set; } = new List<Product>();
        }
    }
}
