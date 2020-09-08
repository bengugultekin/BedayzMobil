using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
using BedayzMobil.Models;

namespace BedayzMobil.Helpers
{
    public class SepetIslemleri
    {
        /*public bool SepeteEkle(Product product, int adet)
        {
            bool mevcut = false;
            List<Product> itemlist = new List<Product>();
            if (Settings.SepetimJson != "")
                itemlist = JsonConvert.DeserializeObject<List<Product>>(Settings.SepetimJson);

            if (adet == 0)
            {
                adet = 1;
            }
            if (itemlist.Count == 0) product.SepetId = 1;
            else
            {
                product.SepetId = itemlist.Last().SepetId + 1;
                foreach (var item in itemlist)
                {
                    if (product.Name == item.Name)
                    {
                        mevcut = true;
                        return mevcut;
                    }
                }

            };
            product.Adet = adet;
            product.Cost = product.Cost * adet;
            itemlist.Add(product);
            Settings.SepetimJson = "";
            Settings.SepetimJson = JsonConvert.SerializeObject(itemlist);
            return mevcut;

        }
        public void SepettenSil(int SepetId)
        {
            var itemlist = JsonConvert.DeserializeObject<List<Product>>(Settings.SepetimJson);
            foreach (var item in itemlist)
            {
                if (item.SepetId == SepetId)
                {
                    itemlist.Remove(item);
                    break;
                }
            }
            Settings.SepetimJson = JsonConvert.SerializeObject(itemlist);
        }
        public void SepetiBoşalt()
        {
            var itemlist = JsonConvert.DeserializeObject<List<Product>>(Settings.SepetimJson);
            itemlist.Clear();
            Settings.SepetimJson = JsonConvert.SerializeObject(itemlist);
        }
        public List<Product> GetSepet()
        {
            List<Product> itemlist = new List<Product>();
            if (!string.IsNullOrWhiteSpace(Settings.SepetimJson))
            {
                itemlist = JsonConvert.DeserializeObject<List<Product>>(Settings.SepetimJson);
            }
            return itemlist;
        }
        public int GetSepetCounts()
        {
            List<Product> itemlist = new List<Product>();
            if (!string.IsNullOrWhiteSpace(Settings.SepetimJson))
            {
                itemlist = JsonConvert.DeserializeObject<List<Product>>(Settings.SepetimJson);
                return itemlist.Count;
            }
            return 0;
        }
        public double ToplamTutar()
        {
            double toplam = 0;
            if (!string.IsNullOrWhiteSpace(Settings.SepetimJson))
            {
                foreach (var item in GetSepet())
                {
                    toplam += item.Cost;
                }
            }
            return toplam;
        }
    }*/
    }
}
