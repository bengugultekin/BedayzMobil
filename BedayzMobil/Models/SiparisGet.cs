using System;
using System.Collections.Generic;
using System.Text;

namespace BedayzMobil.Models
{
    public class SiparisGet
    {
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int Adet { get; set; }
        public int UserId { get; set; }
        public int ProductID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
