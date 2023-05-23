using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class YakitTipi
    {
        public YakitTipi()
        {
            Aracs = new HashSet<Arac>();
        }

        public int YakitTipiId { get; set; }
        public string YakitTipiAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
