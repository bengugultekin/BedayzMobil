using System;
using System.Collections.Generic;
using System.Text;

namespace BedayzMobil.Helpers
{
    public class KullaniciIslemleri
    {
        public void ÇıkışYap()
        {
            Settings.GirişYapıldı = "false";
            Settings.Email = "";
            Settings.AccessToken = "";
            Settings.Password = "";
        }
    }
}
