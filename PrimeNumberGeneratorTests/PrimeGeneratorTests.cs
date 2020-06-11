using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeGenerator.Core;
using System.Linq;

namespace PrimeNumberGeneratorTests
{
    [TestClass]
    public class PrimeGeneratorTests
    {
        private readonly IPrimeGenerator _primeGenerator;

        public PrimeGeneratorTests()
        {
            var services = new ServiceCollection();
            services.AddStandardPrimeGenerator();

            var provider = services.BuildServiceProvider();

            _primeGenerator = provider.GetService<IPrimeGenerator>();
        }

        [TestMethod]
        public void GeneratePrimes()
        {
            var primeList = _primeGenerator.GeneratePrimes(5);

            var expected = new[] { 2, 3, 5, 7, 11 };

            CollectionAssert.AreEqual(expected, primeList.ToArray());
        }
    }
}
