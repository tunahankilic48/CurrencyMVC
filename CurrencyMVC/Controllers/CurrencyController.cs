using CurrencyMVC.Models.DTOs;
using CurrencyMVC.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CurrencyMVC.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CurrencyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44383/api/Currency/GetAllCurrencies");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CurrencyVM>>(jsonData);
                return View(values);
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCurrencyDto createCurrencyDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCurrencyDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44383/api/Currency/AddCurrency", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("index");

            }
            return View(createCurrencyDto);
        }

        public async Task<IActionResult> Update(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44383/api/Currency/GetCurrencyById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCurrencyDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCurrencyDto updateCurrencyDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCurrencyDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:44383/api/Currency/UpdateCurrency", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("index");

            }
            return View(updateCurrencyDto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44383/api/Currency/DeleteCurrency/{id}");

            return RedirectToAction("index");

        }

        public async Task<IActionResult> CurrencyValue()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44383/api/CurrencyDetail/GetLastValueOfCurrencies");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CurrencyDetailVM>>(jsonData);
                return View(values);
            }
            return View();

        }


    }
}
