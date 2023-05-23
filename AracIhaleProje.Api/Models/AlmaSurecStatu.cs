using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class AlmaSurecStatu
    {
        public AlmaSurecStatu()
        {
            Aracs = new HashSet<Arac>();
        }

        public int AlmaSurecStatuId { get; set; }
        public string AlmaSurecStatuAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
