using Autofac; 
using CoinStatIngester.Data;
using CoinStatIngester.Infrastructure;
using System.Net.Http;

namespace CoinStatIngester
{
    public class AutofacConfig
    {
        public ContainerBuilder Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HttpClient>().UsingConstructor();
            builder.RegisterType<WhatToMineStatRepo>().As<IStatRepo>();
            builder.RegisterType<CsvStatWriter>().As<IStatWriter>().WithParameter("writeLocation", "C:\\stats\\");
            builder.RegisterType<Controller>().WithParameter("callIntervalInMinutes", 15);

            return builder;
        }
    }
}