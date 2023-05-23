using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class DonanimBilgisi
    {
        public DonanimBilgisi()
        {
            Aracs = new HashSet<Arac>();
        }

        public int DonanimBilgisiId { get; set; }
        public string DonanimBilgisiIcerik { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
