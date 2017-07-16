using System;
using Autofac;

namespace CoinStatIngester
{
    class Program
    {
        private static IContainer _container;

        static void Main(string[] args)
        {
            var builder = new AutofacConfig().Build();
            _container = builder.Build();

            using(var scope = _container.BeginLifetimeScope())
            {
                var controller = scope.Resolve<Controller>();
                controller.Start();
            }
        }
    }
}
