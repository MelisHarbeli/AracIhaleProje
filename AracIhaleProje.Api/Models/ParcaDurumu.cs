using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class ParcaDurumu
    {
        public ParcaDurumu()
        {
            TramerArkaTampons = new HashSet<Tramer>();
            TramerArkakaputs = new HashSet<Tramer>();
            TramerMotorKaputus = new HashSet<Tramer>();
            TramerOnTampons = new HashSet<Tramer>();
            TramerSagArkaCamurluks = new HashSet<Tramer>();
            TramerSagArkaKapis = new HashSet<Tramer>();
            TramerSagOnCamurluks = new HashSet<Tramer>();
            TramerSagOnKapis = new HashSet<Tramer>();
            TramerSolArkaCamurluks = new HashSet<Tramer>();
            TramerSolArkaKapis = new HashSet<Tramer>();
            TramerSolOnCamurluks = new HashSet<Tramer>();
            TramerSolOnKapis = new HashSet<Tramer>();
            TramerTavans = new HashSet<Tramer>();
        }

        public int ParcaDurumuId { get; set; }
        public string DurumAdi { get; set; }

        public virtual ICollection<Tramer> TramerArkaTampons { get; set; }
        public virtual ICollection<Tramer> TramerArkakaputs { get; set; }
        public virtual ICollection<Tramer> TramerMotorKaputus { get; set; }
        public virtual ICollection<Tramer> TramerOnTampons { get; set; }
        public virtual ICollection<Tramer> TramerSagArkaCamurluks { get; set; }
        public virtual ICollection<Tramer> TramerSagArkaKapis { get; set; }
        public virtual ICollection<Tramer> TramerSagOnCamurluks { get; set; }
        public virtual ICollection<Tramer> TramerSagOnKapis { get; set; }
        public virtual ICollection<Tramer> TramerSolArkaCamurluks { get; set; }
        public virtual ICollection<Tramer> TramerSolArkaKapis { get; set; }
        public virtual ICollection<Tramer> TramerSolOnCamurluks { get; set; }
        public virtual ICollection<Tramer> TramerSolOnKapis { get; set; }
        public virtual ICollection<Tramer> TramerTavans { get; set; }
    }
}
