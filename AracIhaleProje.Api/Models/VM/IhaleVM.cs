using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleProje.Api.Models.VM
{
    public class IhaleVM
    {
        public int IhaleId { get; set; }
        public string IhaleAdi { get; set; }
        public int SirketId { get; set; }
        public int Statü { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        //public string IhaleAdi { get; set; }
        //public int SirketId { get; set; }
        //public int Statü { get; set; }
        //public DateTime BaslangicTarih { get; set; }
        //public DateTime BitisTarih { get; set; }
    }
}
