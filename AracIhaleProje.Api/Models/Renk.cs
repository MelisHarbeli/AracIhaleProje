using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Renk
    {
        public Renk()
        {
            Aracs = new HashSet<Arac>();
        }

        public int RenkId { get; set; }
        public string RenkAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
