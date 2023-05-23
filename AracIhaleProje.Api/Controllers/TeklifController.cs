using AracIhaleProje.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleProje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeklifController : ControllerBase
    {
        private static Teklif _teklif;

        // POST api/Teklif/teklifver
        [HttpPost("teklifver")]
        public IActionResult TeklifVer(decimal teklif)
        {
            if (_teklif == null)
            {
                return NotFound("Aktif bir ihale bulunmamaktadır.");
            }

            if (teklif > _teklif.EnYuksekTeklif)
            {
                _teklif.EnYuksekTeklif = teklif;
                return Ok("Teklif başarıyla kaydedildi.");
            }

            return BadRequest("Teklif, mevcut en yüksek tekliften düşük olamaz.");
        }

        // GET api/Teklif/enyuksek
        [HttpGet("enyuksek")]
        public IActionResult EnYuksekTeklif()
        {
            if (_teklif == null)
            {
                return NotFound("Aktif bir ihale bulunmamaktadır.");
            }

            return Ok(_teklif.EnYuksekTeklif);
        }

        //// POST api/Teklif/ac
        //[HttpPost("ac")]
        //public IActionResult IhaleAc(Ihale ihale)
        //{
        //    if (_ihale != null)
        //    {
        //        return BadRequest("Aktif bir ihale zaten bulunmaktadır.");
        //    }

        //    _ihale = ihale;
        //    return Ok("İhale başarıyla açıldı.");
        //}

    }
}
