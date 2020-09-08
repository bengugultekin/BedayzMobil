using System;
using System.Collections.Generic;
using System.Text;

namespace BedayzMobil.Models
{
    public class Sepet
    {
        public int SepetId { get; set; }
        public int UserId { get; set; }
        public DateTime SepeteKonulmaTarihi { get; set; }
        public int ProductID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
