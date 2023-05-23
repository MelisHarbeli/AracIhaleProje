using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Model
    {
        public Model()
        {
            Aracs = new HashSet<Arac>();
        }

        public int ModelId { get; set; }
        public string ModelAdi { get; set; }
        public int MarkaId { get; set; }
        public int VersiyonId { get; set; }

        public virtual Marka Marka { get; set; }
        public virtual Versiyon Versiyon { get; set; }
        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
