using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BedayzMobil.Models
{
    public class RadioButtonsModel
    {
        public ERadioButtonProperty Property { get; set; }
        public string TextString { get; set; }
    }
    public enum ERadioButtonProperty : byte
    {
        [Description("Azalan")]
        Azalan = 1,

        [Description("Artan")]
        Artan = 2
    }
}
