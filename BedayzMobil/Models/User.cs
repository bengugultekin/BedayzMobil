using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BedayzMobil.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
        public IList<Sepet> Sepetler { get; set; }
        public IList<Siparis> Siparisler { get; set; }
    }
}
