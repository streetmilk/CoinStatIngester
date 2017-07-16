using System;
using System.Collections.Generic;
using CoinStatIngester.Models.WhatToMine;
using System.IO;

namespace CoinStatIngester.Infrastructure
{
    public class CsvStatWriter : IStatWriter
    {
        private readonly string _writeLocation;
        public CsvStatWriter(string writeLocation)
        {
            if(writeLocation.EndsWith("\\"))
                _writeLocation = writeLocation;
            else
                _writeLocation = writeLocation + "\\";
        }

        public void Write(CoinCollection data)
        {
            using (var stream = new FileStream(GetFullFilePath(), FileMode.CreateNew))
            {
                using (var writer = new StreamWriter(stream))
                {
                    //always write header line
                    writer.WriteLine("Name, Id, Tag, Algorithm, Block Time, Block Reward, Block Reward 24, Last Block, Difficulty, Difficulty 24, Net Hash, Exchange Rate, Exchange Rate 24, Exchange Rate Vol, Exchange Rate Curr, Market Cap, Estimated Rewards, Estimated Rewards 24, Btc Revenue, Btc Revenue 24, Profitability, Profitability 24, Lagging, Timestamp");
                    foreach(var item in data.coins)
                    {
                        writer.WriteLine($"{item.Key}, {item.Value.ToString()}");
                    }
                }
            }
        }

        private string GetFullFilePath()
        {
            var dtString = DateTime.UtcNow.ToString("yyyyMMddHHmmss");

            return $"{_writeLocation}coinstats_{dtString}.csv";   
        }
    }
}