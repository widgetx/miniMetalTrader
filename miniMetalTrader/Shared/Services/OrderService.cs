using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using miniMetalTrader.Shared;

namespace miniMetalTrader.Shared.Services
{
    public class OrderService
    {
        public async Task<Order> CreateOrderAsync(Order order)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var azCustomersMongoDBUrl = "https://getcustomers.azurewebsites.net/api/{DONT PUT KEYS INLINE IN CODE}";
                await httpClient.GetFromJsonAsync<Client[]>(new Uri(azCustomersMongoDBUrl));

            }
            catch
            {
                Console.WriteLine("Not implemented yet...");
            }

            order.PositionId = DateTime.Now.Ticks;
            order.Status = PositionStatus.Created;

            return order;
        }

        public async Task<Order> CommitOrderAsync(Order order)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var azCustomersMongoDBUrl = "https://getcustomers.azurewebsites.net/api/{DONT PUT KEYS INLINE IN CODE}";
                await httpClient.GetFromJsonAsync<Client[]>(new Uri(azCustomersMongoDBUrl));
            }
            catch
            {
                Console.WriteLine("Not implemented yet...");
            }
            
            order.Status = PositionStatus.Executing;
            order.Status = PositionStatus.Filled;
            return order;
        }

    }
}
