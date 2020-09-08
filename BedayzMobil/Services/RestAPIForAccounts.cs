using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BedayzMobil.Models;
using Microsoft.CSharp;
using Settings = BedayzMobil.Helpers.Settings;
using Xamarin.Forms;
using BedayzMobil.Helpers;

namespace BedayzMobil.Services
{
    public class RestAPIForAccounts
    {
        private string _ApiUrl = "https://bedayzapi.azurewebsites.net/";
        public async Task<bool> Register(string email, string password, string name, string lastName, string userName)
        {
            var model = new User()
            {
                Email = email,
                Password = password,
                Name = name,
                LastName = lastName,
                UserName = userName
            };
            HttpClient client = new HttpClient();
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            var response = await client.PostAsync(_ApiUrl + "api/users", content);
            return response.IsSuccessStatusCode;
        }
        public async Task<string> LoginAsync(string email, string password)
        {
            var userInfos = new LoginModel() { Email = email, Password = password };
            var jsonObj = JsonConvert.SerializeObject(userInfos);
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonObj.ToString(), Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(_ApiUrl + "api/login"),
                    Method = HttpMethod.Post,
                    Content = content
                };
                //you can add headers                
                //request.Headers.Add("key", "value");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    Settings.GirişYapıldı = "true";
                }
                string jwt = await response.Content.ReadAsStringAsync();
                JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);
                var accessToken = jwtDynamic.Value<string>("accessToken");

                return accessToken;
            }

        }

        public async Task<List<Siparis>> GetAuthorizeSiparişler(string email, string accestoken)
        {
            var Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
            var json = await Client.GetStringAsync(_ApiUrl + "siparisler/" + email);
            var siparisler = JsonConvert.DeserializeObject<List<Siparis>>(json);
            return siparisler;
        }
        public void GetUserInfo(string email)
        {

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(_ApiUrl)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/users/" + email).Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<User>().Result;
                Settings.UserId = items.Id.ToString();
                Settings.UserName = items.UserName;
                Settings.Name = items.Name;
                Settings.LastName = items.LastName;

            }
        }
        public async Task<bool> PostSiparis(Siparis siparisler)
        {
            HttpClient client = new HttpClient();
            var json = JsonConvert.SerializeObject(siparisler);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            var response = await client.PostAsync(_ApiUrl + "api/siparisler", content);
            return response.IsSuccessStatusCode;
        }
        public List<SiparisGet> GetSiparisler(string email)
        {

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(_ApiUrl)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/siparisler/" + email).Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<List<SiparisGet>>().Result;
                return items;

            }
            return new List<SiparisGet>();
        }
    }
}
