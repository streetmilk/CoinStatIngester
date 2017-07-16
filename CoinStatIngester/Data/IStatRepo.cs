using System.Collections.Generic;
using CoinStatIngester.Models.WhatToMine;

namespace CoinStatIngester.Data
{
    public interface IStatRepo
    {
        IDictionary<string, CoinStat> Get();
    }
}
