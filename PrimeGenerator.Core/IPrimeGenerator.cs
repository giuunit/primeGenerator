using System.Collections.Generic;

namespace PrimeGenerator.Core
{
    public interface IPrimeGenerator
    {
        IEnumerable<int> GeneratePrimes(int limit);
    }
}
