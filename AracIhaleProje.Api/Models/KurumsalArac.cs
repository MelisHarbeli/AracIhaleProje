using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class KurumsalArac
    {
        public int AracId { get; set; }
        public int KurumsalUserId { get; set; }
        public int KurumsalAracId { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual KurumsalUser KurumsalUser { get; set; }
    }
}
