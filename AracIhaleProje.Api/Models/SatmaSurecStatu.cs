using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class SatmaSurecStatu
    {
        public SatmaSurecStatu()
        {
            Aracs = new HashSet<Arac>();
        }

        public int SatmaSurecStatuId { get; set; }
        public string SatmaSurecStatuAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
