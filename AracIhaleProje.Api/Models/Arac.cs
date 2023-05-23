using System;
using System.Collections.Generic;

#nullable disable

namespace AracIhaleProje.Api.Models
{
    public partial class Arac
    {
        public Arac()
        {
            BireyselAracs = new HashSet<BireyselArac>();
            IhaledeAraclars = new HashSet<IhaledeAraclar>();
            KurumsalAracs = new HashSet<KurumsalArac>();
        }

        public int AracId { get; set; }
        public double Km { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }
        public string Foto3 { get; set; }
        public string Foto4 { get; set; }
        public string Foto5 { get; set; }
        public int User { get; set; }
        public string Açıklama { get; set; }
        public int GovdeTipiId { get; set; }
        public int YakitTipiId { get; set; }
        public int VitesTipiId { get; set; }
        public int VersiyonId { get; set; }
        public int RenkId { get; set; }
        public int DonanimId { get; set; }
        public int AlmaSurecStatuId { get; set; }
        public int SatmaSurecStatuId { get; set; }
        public int MarkaId { get; set; }
        public int ModelId { get; set; }
        public int TramerId { get; set; }
        public string Yil { get; set; }

        public virtual AlmaSurecStatu AlmaSurecStatu { get; set; }
        public virtual DonanimBilgisi Donanim { get; set; }
        public virtual GovdeTipi GovdeTipi { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Model Model { get; set; }
        public virtual Renk Renk { get; set; }
        public virtual SatmaSurecStatu SatmaSurecStatu { get; set; }
        public virtual Tramer Tramer { get; set; }
        public virtual Versiyon Versiyon { get; set; }
        public virtual VitesTipi VitesTipi { get; set; }
        public virtual YakitTipi YakitTipi { get; set; }
        public virtual ICollection<BireyselArac> BireyselAracs { get; set; }
        public virtual ICollection<IhaledeAraclar> IhaledeAraclars { get; set; }
        public virtual ICollection<KurumsalArac> KurumsalAracs { get; set; }
    }
}
