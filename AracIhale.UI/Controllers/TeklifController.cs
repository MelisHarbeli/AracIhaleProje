using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhale.UI.Controllers
{
    public class TeklifController : Controller
    {
        private readonly HttpClient _httpClient;

        public TeklifController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:8869/api/Teklif/");
        }

        //public async Task<IActionResult> IhaleAc()
        //{
        //    var ihale = new Ihale { Baslik = "Örnek İhale", MinimumTeklif = 100 };
        //    var response = await _httpClient.PostAsJsonAsync("ac", ihale);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var result = await response.Content.ReadAsStringAsync();
        //        ViewBag.Message = result;
        //    }
        //    else
        //    {
        //        ViewBag.Message = "İhale açma işlemi başarısız oldu.";
        //    }

        //    return View();
        //}

        public async Task<IActionResult> TeklifVer(decimal teklif)
        {
            var response = await _httpClient.PostAsync($"teklifver?teklif={teklif}", null);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ViewBag.Message = result;
            }
            else
            {
                ViewBag.Message = "Teklif verme işlemi başarısız oldu.";
            }

            return View();
        }

        public async Task<IActionResult> EnYuksekTeklif()
        {
            var response = await _httpClient.GetAsync("enyuksek");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                ViewBag.EnYuksekTeklif = result;
            }
            else
            {
                ViewBag.EnYuksekTeklif = "En yüksek teklif getirme işlemi başarısız oldu.";
            }

            return View();
        }
    }
}
