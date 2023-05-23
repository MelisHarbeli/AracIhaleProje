using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class BireyselArac
    {
        public int AracId { get; set; }
        public int BireyselAracId { get; set; }
        public int BireyselUserId { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual BireyselUser BireyselUser { get; set; }
    }
}
