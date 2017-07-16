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

        public IDictionary<string, CoinStat> Get()
        {
            var result = _client.GetAsync(statUrl).Result;

            return JsonConvert.DeserializeObject<Dictionary<string,CoinStat>>(result.Content.ToString());
        }
    }
}