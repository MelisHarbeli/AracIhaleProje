using AracIhale.UI.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.Provider
{
    public class IhaleEkleProvider
    {
        HttpClient _httpClient;
        public IhaleEkleProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<IhaleDTO>> VerileriGetir()
        {
            List<IhaleDTO> listem = null;
            var responseMessage = await _httpClient.GetAsync("Ihale");
            if (responseMessage.IsSuccessStatusCode)
            {
                listem = JsonConvert.DeserializeObject<List<IhaleDTO>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return listem;
        }
        public async Task<IhaleDTO> IhaleAc(IhaleDTO dto)
        {
           string json= JsonConvert.SerializeObject(dto);
            try
            {
                HttpResponseMessage response = _httpClient.PostAsync("IhaleEkle", new StringContent(json, Encoding.UTF8, "application/json")).Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<IhaleDTO>(result);
                    if (data != null)
                        dto = data;
                }
                else
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    throw new Exception("Error: " + result);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return dto;
            //var responseMessage = await _httpClient.PostAsJsonAsync("IhaleEkle",dto);


            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return "Başarılı şekilde eklendi.";
            //}
            //return "Başarısız";
        }
    }
}
