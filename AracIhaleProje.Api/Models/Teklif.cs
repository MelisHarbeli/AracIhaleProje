using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Teklif
    {
        public int TeklifId { get; set; }
        public int? UserId { get; set; }
        public decimal MinTeklif { get; set; }
        public decimal EnYuksekTeklif { get; set; }
        public int IhaleId { get; set; }

        public virtual Ihale Ihale { get; set; }
        public virtual BireyselUser User { get; set; }
        public virtual KurumsalUser UserNavigation { get; set; }
    }
}
