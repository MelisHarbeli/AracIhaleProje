using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class IhaleStatu
    {
        public IhaleStatu()
        {
            Ihales = new HashSet<Ihale>();
        }

        public int StatuId { get; set; }
        public string StatuAdi { get; set; }

        public virtual ICollection<Ihale> Ihales { get; set; }
    }
}
