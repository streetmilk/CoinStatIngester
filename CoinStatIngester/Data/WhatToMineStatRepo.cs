using System.Collections.Generic;
using System.Net.Http;
using CoinStatIngester.Models.WhatToMine;
using Newtonsoft.Json;

//https://whattomine.com/coins.json
namespace CoinStatIngester.Data
{
    public class WhatToMineStatRepo : IStatRepo
    {
        private static string statUrl = "https://whattomine.com/coins.json";
        private readonly HttpClient _client;

        public WhatToMineStatRepo(HttpClient client)
        {
            _client = client;
        }

        public CoinCollection Get()
        {
            HttpResponseMessage result =  _client.GetAsync(statUrl).Result;
            
            result.EnsureSuccessStatusCode();
            
            string responseBody = result.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<CoinCollection>(responseBody);
        }
    }
}