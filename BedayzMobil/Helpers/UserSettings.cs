using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BedayzMobil.Helpers
{
    public class UserSettings
    {
        public string GirisYapıldı
        {
            get
            {
                return BedayzMobil.Helpers.Settings.GirişYapıldı;
            }
            set
            {

                BedayzMobil.Helpers.Settings.GirişYapıldı = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
