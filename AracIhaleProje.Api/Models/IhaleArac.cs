using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class IhaleArac
    {
        public int IhaleAracId { get; set; }
        public int IhaleId { get; set; }
        public int AracId { get; set; }
        public decimal BaslangicFiyat { get; set; }
        public decimal MinAlimFiyat { get; set; }
        public int? User { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Ihale Ihale { get; set; }
    }
}
