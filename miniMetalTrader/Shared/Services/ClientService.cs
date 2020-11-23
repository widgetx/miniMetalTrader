using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using miniMetalTrader.Shared;

namespace miniMetalTrader.Shared.Services
{
    // Will fiddle about with a singleton for some Inmemory test data before trying to integrate a DI store via browser or MDB/CosmosDB/DocumentDB etc.
    public class ClientService
    {
        private static Instrument[] _Instruments;
        private static Client[] _Clients;
        public async Task<Client[]> GetClientsAsync(int page = 0, int size = 10)
        {
            HttpClient httpClient = new HttpClient();
            var azCustomersMongoDBUrl = "https://getcustomers.azurewebsites.net/api/{DONT PUT KEYS INLINE IN CODE}";
            Client[] clients = await httpClient.GetFromJsonAsync<Client[]>(new Uri(azCustomersMongoDBUrl));

            return clients;
        }

        public Instrument[] GetInstruments()
        {
            return Instruments();
        }

        public static Instrument[] Instruments()
        {
            if (_Instruments is null)
            {
                _Instruments = new Instrument[] 
                {
                    new Instrument { ISIN = "OTC", Description = "Gold 1oz 999", Price = 1600, Ticker = "XAU", ValueDate = DateTime.Now },
                    new Instrument { ISIN = "OTC", Description = "Silver 1oz 999", Price = 22, Ticker = "XAG", ValueDate = DateTime.Now }
                };
            }
            return _Instruments;
        }

        public Client[] GetClients()
        {
            Instrument[] inst = GetInstruments();
            if (_Clients is null)
            {
                _Clients = new Client[]
              {
                    new Client{
                        Name="Mr Big Stacker",
                        ClientId="101",

                        Account=new Account{
                            Id="1001",
                            Currency="USD",
                            Balance = 50000M,
                            Positions=new List<IPosition>(){
                                new Order{
                                    Instrument=inst.Where(i=>i.Ticker=="XAU").FirstOrDefault(),
                                    OrderType=OrderTypes.Buy,
                                    Price=2000,
                                    Quantity=1,
                                    PositionId=100001,
                                    Status=PositionStatus.Created
                                },
                                new Transaction
                                {
                                    Instrument=inst.First(i=>i.Ticker=="XAU"),
                                    OrderType=OrderTypes.Buy,
                                    Price=2000,
                                    Quantity=1,
                                    PositionId=100001,
                                    Status=PositionStatus.Filled
                                },

                                new Order{
                                    Instrument=inst.First(i=>i.Ticker=="XAG"),
                                    OrderType=OrderTypes.Buy,
                                    Price=20,
                                    Quantity=12,
                                    PositionId=100002,
                                    Status=PositionStatus.Created
                                },
                                new Transaction
                                {
                                    Instrument=inst.First(i=>i.Ticker=="XAG"),
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

            return _Clients;
        }
    }
}
