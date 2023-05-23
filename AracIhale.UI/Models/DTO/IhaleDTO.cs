using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhale.UI.Models.DTO
{
    public class IhaleDTO
    {
        public string IhaleAdi { get; set; }
        public int SirketId { get; set; }
        public int Statü { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
    }
}
