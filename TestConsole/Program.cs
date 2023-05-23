using AracIhaleProje.Api.DAL.İhaleEkleDAL;
using AracIhaleProje.Api.Models.VM;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IhaleEkleDAL dal = new IhaleEkleDAL();
            IhaleVM vm = new IhaleVM();
            vm.IhaleAdi = "Deneme1";
            vm.SirketId = 1;
            vm.Statü = 1;
            vm.BaslangicTarih = DateTime.Now;
            vm.BitisTarih = DateTime.Now.AddDays(1);
            dal.IhaleEkle(vm);
           //var liste= dal.IhaleListele();
           // foreach (var item in liste)
           // {
           //     Console.WriteLine(item.IhaleAdi);
           // }
            Console.ReadLine();
        }
    }
}
