using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class BireyselUser
    {
        public BireyselUser()
        {
            BireyselAracs = new HashSet<BireyselArac>();
            Teklifs = new HashSet<Teklif>();
        }

        public int BireyselUserId { get; set; }
        public string IsimSoyisim { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Sifre { get; set; }
        public bool IsActive { get; set; }
        public bool IsKvkkCheck { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual ICollection<BireyselArac> BireyselAracs { get; set; }
        public virtual ICollection<Teklif> Teklifs { get; set; }
    }
}
