using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Tramer
    {
        public Tramer()
        {
            Aracs = new HashSet<Arac>();
        }

        public int TramerId { get; set; }
        public int SagArkaCamurlukId { get; set; }
        public int SolArkaCamurlukId { get; set; }
        public int SagArkaKapiId { get; set; }
        public int SolArkaKapiId { get; set; }
        public int SagOnKapiId { get; set; }
        public int SolOnKapiId { get; set; }
        public int TavanId { get; set; }
        public int SagOnCamurlukId { get; set; }
        public int SolOnCamurlukId { get; set; }
        public int MotorKaputuId { get; set; }
        public int OnTamponId { get; set; }
        public int ArkaTamponId { get; set; }
        public int ArkakaputId { get; set; }
        public decimal TramerTutar { get; set; }

        public virtual ParcaDurumu ArkaTampon { get; set; }
        public virtual ParcaDurumu Arkakaput { get; set; }
        public virtual ParcaDurumu MotorKaputu { get; set; }
        public virtual ParcaDurumu OnTampon { get; set; }
        public virtual ParcaDurumu SagArkaCamurluk { get; set; }
        public virtual ParcaDurumu SagArkaKapi { get; set; }
        public virtual ParcaDurumu SagOnCamurluk { get; set; }
        public virtual ParcaDurumu SagOnKapi { get; set; }
        public virtual ParcaDurumu SolArkaCamurluk { get; set; }
        public virtual ParcaDurumu SolArkaKapi { get; set; }
        public virtual ParcaDurumu SolOnCamurluk { get; set; }
        public virtual ParcaDurumu SolOnKapi { get; set; }
        public virtual ParcaDurumu Tavan { get; set; }
        public virtual ICollection<Arac> Aracs { get; set; }
    }
}
