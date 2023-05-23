using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class KurumsalUser
    {
        public KurumsalUser()
        {
            Ihales = new HashSet<Ihale>();
            KurumsalAracs = new HashSet<KurumsalArac>();
            Teklifs = new HashSet<Teklif>();
        }

        public int KurumsalUserId { get; set; }
        public string KurumAdi { get; set; }
        public string ContactAdiSoyadi { get; set; }
        public string Tel { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public bool IsActive { get; set; }
        public bool IsKvkkCheck { get; set; }
        public bool IsAnonim { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual ICollection<Ihale> Ihales { get; set; }
        public virtual ICollection<KurumsalArac> KurumsalAracs { get; set; }
        public virtual ICollection<Teklif> Teklifs { get; set; }
    }
}
