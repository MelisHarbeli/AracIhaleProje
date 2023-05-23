using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Ihale
    {
        public Ihale()
        {
            IhaledeAraclars = new HashSet<IhaledeAraclar>();
            Teklifs = new HashSet<Teklif>();
        }

        public int IhaleId { get; set; }
        public string IhaleAdi { get; set; }
        public int SirketId { get; set; }
        public int Statü { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }

        public virtual KurumsalUser Sirket { get; set; }
        public virtual IhaleStatu StatüNavigation { get; set; }
        public virtual ICollection<IhaledeAraclar> IhaledeAraclars { get; set; }
        public virtual ICollection<Teklif> Teklifs { get; set; }
    }
}
