using System.Collections.Generic;
using CoinStatIngester.Models.WhatToMine;

namespace CoinStatIngester.Infrastructure
{
    public interface IStatWriter
    {
        void Write(CoinCollection data);
    }    
}