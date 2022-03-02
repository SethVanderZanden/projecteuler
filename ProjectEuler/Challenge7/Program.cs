using System;
using System.Collections.Generic;
namespace Challenge7
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            // prime numbers can only be divisible by themselves and 1

            List<long> allPrimes = new List<long>();
            
            
            for(long i = 1; allPrimes.Count < 10002; ++i)
            {
                bool isPrime = true;
                for (long j = 2; j < i; ++j)
                {
                    if (i % j == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    //Console.WriteLine(allPrimes.Count);
                    allPrimes.Add(i);
                }
            }

            Console.WriteLine(allPrimes[allPrimes.Count - 1]);

        }
    }
}
