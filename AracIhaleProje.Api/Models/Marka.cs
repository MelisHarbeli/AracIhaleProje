using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Marka
    {
        public Marka()
        {
            Aracs = new HashSet<Arac>();
            Models = new HashSet<Model>();
        }

        public int MarkaId { get; set; }
        public string MarkaAdi { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
