using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class AdminUser
    {
        public int AdminUserId { get; set; }
        public string IsımSoyisim { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public bool IsActive { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
