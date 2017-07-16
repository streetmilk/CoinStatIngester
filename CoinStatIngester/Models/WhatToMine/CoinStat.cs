namespace CoinStatIngester.Models.WhatToMine
{
    public class CoinStat
    {
        
        public int id { get; set; }
        public string tag { get; set; }
        public string algorithm { get; set; }
        public string block_time {get;set;}
        public double block_reward{get;set;}
        public double block_reward24{get;set;}
        public int last_block{get;set;}
        public double difficulty {get;set;}
        public double difficulty24{get;set;}
        public string nethash {get;set;}
        public double exchange_rate{get;set;}
        public double exchange_rate24{get;set;}
        public double exchange_rate_vol{get;set;}
        public string exchange_rate_curr{get;set;}
        public string market_cap {get;set;}
        public string estimated_rewards {get;set;}
        public string estimated_rewards24 {get;set;}
        public string btc_revenue {get;set;}
        public string btc_revenue24{get;set;}
        public int profitability {get;set;}
        public int profitability24{get;set;}
        public bool lagging {get;set;}
        public int timestamp {get;set;}

        public override string ToString()
        {
            return $"{id}, {tag}, {algorithm}, {block_time}, {block_reward}, {block_reward24}," + 
            $"{last_block}, {difficulty}, {difficulty24}, {nethash}, {exchange_rate}, {exchange_rate24}," +
            $"{exchange_rate_vol}, {exchange_rate_curr}, {market_cap}, {estimated_rewards}, {estimated_rewards24}"+
            $"{btc_revenue}, {btc_revenue24}, {profitability}, {profitability24}, {lagging}, {timestamp}";   
        }
    }
}