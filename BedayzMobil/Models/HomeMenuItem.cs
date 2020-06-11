using System;
using System.Collections.Generic;
using System.Text;

namespace BedayzMobil.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Hoodie
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
