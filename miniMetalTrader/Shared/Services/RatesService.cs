using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using miniMetalTrader.Shared;

namespace miniMetalTrader.Shared.Services
{
    public class RatesService
    {
        //public async Task<Client[]> GetRatesAsync(string BaseCurrency = "USD")
        //{
        //    HttpClient httpClient = new HttpClient();
        //    var azCustomersMongoDBUrl = "https://getcustomers.azurewebsites.net/api/{DONT PUT KEYS INLINE IN CODE}";
        //    FXRate[] FXRates = await httpClient.GetFromJsonAsync<Client[]>(new Uri(azCustomersMongoDBUrl));

        //    return clients;
        //}

        public static FXRate[] GetRates()
        {
            var rates = new FXRate[]
            {
                new FXRate{ Base="USD", To="CHF", Rate=0.91M, ValueDate=DateTime.Now},
                new FXRate{ Base="USD", To="GBP", Rate=0.75M, ValueDate=DateTime.Now},
                new FXRate{ Base="USD", To="GBP", Rate=0.84M, ValueDate=DateTime.Now}
            };
            return rates;
        }

    }
}
