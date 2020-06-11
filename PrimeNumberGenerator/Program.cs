using Microsoft.Extensions.DependencyInjection;
using PrimeGenerator.Core;
using System;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSOSPrimeGenerator();

            var provider = services.BuildServiceProvider();

            var generator = provider.GetService<IPrimeGenerator>();

            Console.WriteLine("Enter a number");

            var success = int.TryParse(Console.ReadLine(), out int limit);

            if (!success)
            {
                Console.WriteLine("Not a number. Bye");
                Environment.Exit(0);
            }

            var res = generator.GeneratePrimes(limit);

            Console.Write(string.Join(",", res));

            Console.Read();
        }
    }
}
