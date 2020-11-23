using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using miniMetalTrader.Shared;

namespace miniMetalTrader.Shared.Services
{
    public class ClientService
    {
        public async Task<Client[]> GetClientsAsync(int page = 0, int size = 10)
        {
            HttpClient httpClient = new HttpClient();
            var azCustomersMongoDBUrl = "https://getcustomers.azurewebsites.net/api/{DONT PUT KEYS INLINE IN CODE}";
            Client[] clients = await httpClient.GetFromJsonAsync<Client[]>(new Uri(azCustomersMongoDBUrl));

            return clients;
        }

        public static Instrument[] GetInstruments()
        {
            var instruments = new Instrument[]
            {
                new Instrument{ ISIN = "OTC", Description = "Gold 1oz 999", Price=1600, Ticker="AU", ValueDate=DateTime.Now},
                new Instrument{ ISIN = "OTC", Description = "Silver 1oz 999", Price=22, Ticker="AG", ValueDate=DateTime.Now}
            };
            return instruments;
        }

        public Client[] GetClients()
        {
            return ClientService.Clients();
        }

        public static Client[] Clients()
        {
            var inst = GetInstruments();

            return new Client[]
            {
                new Client{
                    Name="Stacker 101",
                    ClientId="101",
                    
                    Account=new Account{ 
                        Id="101",
                        Currency="USD",
                        Positions=new List<IPosition>(){
                            new Order{
                                Instrument=inst.Where(i=>i.Ticker=="AU").FirstOrDefault(), 
                                OrderType=OrderTypes.Buy, 
                                Price=2000, 
                                Quantity=1,
                                PositionId=100001,
                                Status=PositionStatus.Created
                            },
                            new Transaction
                            {
                                Instrument=inst.First(i=>i.Ticker=="AU"),
                                OrderType=OrderTypes.Buy,
                                Price=2000,
                                Quantity=1,
                                PositionId=100001,
                                Status=PositionStatus.Filled
                            },


                            new Order{
                                Instrument=inst.First(i=>i.Ticker=="AG"),
                                OrderType=OrderTypes.Buy,
                                Price=20,
                                Quantity=12,
                                PositionId=100002,
                                Status=PositionStatus.Created
                            },
                            new Transaction
                            {
                                Instrument=inst.First(i=>i.Ticker=="AG"),
                                OrderType=OrderTypes.Buy,
                                Price=20,
                                Quantity=12,
                                PositionId=100002,
                                Status=PositionStatus.Filled
                            }
                        } 
                    }   
                }
            };
        }
    }
}
