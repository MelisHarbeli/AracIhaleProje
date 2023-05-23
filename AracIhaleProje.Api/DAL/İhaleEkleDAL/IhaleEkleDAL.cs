using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AracIhaleProje.Api;
using AracIhaleProje.Api.DAL.Interfaces;
using AracIhaleProje.Api.Models.VM;
using AracIhaleProje.Api.Models;

namespace AracIhaleProje.Api.DAL.İhaleEkleDAL
{
    public class IhaleEkleDAL:IhaleRepoBase<Ihale,AracİhaleDBContextContext>,IIhaleDAL
    {
        public async Task RemoveAsync(Ihale ihale)
        {
            using (AracİhaleDBContextContext db = new AracİhaleDBContextContext())
            {
                var SilinecekData = await db.Ihales.FindAsync(ihale.IhaleId);
                db.Ihales.Remove(SilinecekData);
                db.SaveChanges();


            }
        }

        public async Task UpdateAsync(Ihale ihale)
        {
            using (AracİhaleDBContextContext db = new AracİhaleDBContextContext())
            {
                var DegisecekData = await db.Ihales.FindAsync(ihale.IhaleId);
                DegisecekData.IhaleAdi = ihale.IhaleAdi;
                DegisecekData.SirketId = ihale.SirketId;
                DegisecekData.Statü = ihale.Statü;
                DegisecekData.BaslangicTarih = ihale.BaslangicTarih;
                DegisecekData.BitisTarih = ihale.BitisTarih;
                 db.SaveChanges();


            }
        }
        //public void IhaleEkle(IhaleVM vm)
        //{
        //    Ihale ihale = new Ihale()
        //    {

        //        IhaleAdi = vm.IhaleAdi,
        //        SirketId = vm.SirketId,
        //        Statü = vm.Statü,
        //        BaslangicTarih = vm.BaslangicTarih,   
        //        BitisTarih =vm.BitisTarih


        //    };

        //    db.Ihales.Add(ihale);
        //    db.SaveChanges();
        //}
        //public List<IhaleVM> IhaleListele()
        //{
        //    List<IhaleVM> listemVM = new List<IhaleVM>();
        //   List<Ihale> listem= db.Ihales.ToList();
        //    foreach (var item in listem)
        //    {
        //        IhaleVM vm = new IhaleVM()
        //        {
        //            IhaleAdi = item.IhaleAdi,
        //            SirketId = item.SirketId,
        //            Statü = item.Statü,
        //            BaslangicTarih = item.BaslangicTarih,
        //            BitisTarih = item.BitisTarih
        //        };
        //        listemVM.Add(vm);
        //    }
        //    return listemVM;
        //}
    }
}
