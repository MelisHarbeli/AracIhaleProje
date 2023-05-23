using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class GovdeTipi
    {
        public GovdeTipi()
        {
            Aracs = new HashSet<Arac>();
        }

        public int GovdeTipiId { get; set; }
        public string GovdeTipiAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
