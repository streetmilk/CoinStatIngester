using CoinStatIngester.Data;
using CoinStatIngester.Infrastructure;
using System;
using System.Threading;

namespace CoinStatIngester
{
    public class Controller
    {
        private readonly IStatRepo _repo;
        private readonly IStatWriter _writer;
        private readonly int _callIntervalInMinutes;

        public Controller(IStatRepo repo, 
        IStatWriter writer,
        int callIntervalInMinutes)
        {
            _repo = repo;
            _writer = writer;
            _callIntervalInMinutes = callIntervalInMinutes;            
        }

        public void Start()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("---------- Calling For Stats ------------");
                    var stats = _repo.Get();
                    _writer.Write(stats);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ran into error.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                               
                Console.WriteLine($"----- sleeping for {_callIntervalInMinutes} minutes -----");
                Thread.Sleep(_callIntervalInMinutes * 60 * 1000);
            }
        }
    }
}