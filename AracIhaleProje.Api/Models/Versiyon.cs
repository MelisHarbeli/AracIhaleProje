using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Versiyon
    {
        public Versiyon()
        {
            Aracs = new HashSet<Arac>();
            Models = new HashSet<Model>();
        }

        public int VersiyonId { get; set; }
        public string Versiyonu { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
