using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class ECommerceController : Controller
    {
        public async Task<IActionResult> ECommerceList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-product-search.p.rapidapi.com/search-light-v2?q=logitech%20fare&country=tr&language=en&page=1&limit=10&sort_by=BEST_MATCH&product_condition=ANY&return_filters=false"),
                Headers =
    {
        { "x-rapidapi-key", "18886d9fb0msh2e6d2ac268d0c25p151927jsn9c90c20268ed" },
        { "x-rapidapi-host", "real-time-product-search.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ECommerceViewModel>(body);
                return View(values.data.products.ToList());
            }
            
        }
    }
}
