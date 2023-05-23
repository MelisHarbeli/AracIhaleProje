using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Rol
    {
        public Rol()
        {
            AdminUsers = new HashSet<AdminUser>();
            BireyselUsers = new HashSet<BireyselUser>();
            KurumsalUsers = new HashSet<KurumsalUser>();
        }

        public int RolId { get; set; }
        public string Rolu { get; set; }

        public virtual ICollection<AdminUser> AdminUsers { get; set; }
        public virtual ICollection<BireyselUser> BireyselUsers { get; set; }
        public virtual ICollection<KurumsalUser> KurumsalUsers { get; set; }
    }
}
