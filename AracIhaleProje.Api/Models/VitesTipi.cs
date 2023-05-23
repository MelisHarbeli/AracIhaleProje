using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class VitesTipi
    {
        public VitesTipi()
        {
            Aracs = new HashSet<Arac>();
        }

        public int VitesTipiId { get; set; }
        public string VitesTipiAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
