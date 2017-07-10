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
    }
}