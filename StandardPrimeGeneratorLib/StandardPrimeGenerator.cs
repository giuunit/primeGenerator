using PrimeGenerator.Core;
using System;
using System.Collections.Generic;

namespace PrimeNumberGenerator
{
    public class StandardPrimeGenerator : IPrimeGenerator
    {
        public IEnumerable<int> GeneratePrimes(int limit)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < limit)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
    }
}
