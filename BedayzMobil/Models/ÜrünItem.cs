using System;
using System.Collections.Generic;
using System.Text;

namespace BedayzMobil.Models
{
    public class ÜrünItem
    {
        private string image;
        public string ImageSource
        {
            get { return image; }
            set { image = value; }
        }

        private string ürünIsmi;
        public string Ürünİsmi
        {
            get { return ürünIsmi; }
            set { ürünIsmi = value; }
        }
        private string ürünDetayı;
        public string ÜrünDetayı
        {
            get { return ürünDetayı; }
            set { ürünDetayı = value; }
        }
        private string ürünFiyatı;
        public string ÜrünFiyatı
        {
            get { return ürünFiyatı; }
            set { ürünFiyatı = value; }
        }
    }
}
