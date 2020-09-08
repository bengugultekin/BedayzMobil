using System;
using System.Collections.Generic;
using System.Text;

namespace BedayzMobil.Models
{
    public enum PCMenuItemType
    {
        Corap
    }
    public class PCMenuItem
    {
        public PCMenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
