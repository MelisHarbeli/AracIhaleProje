using AracIhale.UI.Models.DTO;
using AracIhale.UI.Provider;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.Controllers
{

    public class IhaleEkleController : Controller
    {
       IhaleEkleProvider _provider;
        private readonly HttpClient _httpClient;
        public IhaleEkleController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("http://localhost:8869/api/Ihale");
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Listele()
        //{
        //    var hde=List<IhaleDTO>
        //    return View();
        //}
       
        public async Task<IActionResult> Ac(IhaleDTO dto)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("IhaleEkle",jsonContent);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                // Verileri işleyin veya görüntüleyin
            }
            else
            {
                // İstek başarısız oldu, hata işleme kodunu burada yazın
            }

            return View();
        }
        public async Task<IActionResult> Liste()
        {
            var apidenGelenSonucKumesi = await _provider.VerileriGetir(); ;
            return View(apidenGelenSonucKumesi);
        }
    }
}
