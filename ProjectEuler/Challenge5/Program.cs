using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge5
{
    class Program
    {
        public static List<long> FindPrimeNumbersUnderN(long n)
        {
            // between [2, sqrt(n) + 1]
            //Console.WriteLine(Math.Sqrt(n + 1));
            List<long> primes = new List<long>();

            for (long i = 2; i < Math.Sqrt(n + 1); ++i)
            {
                if (i < Math.Sqrt(n + 1))
                {
                    if (n % i == 0)
                        primes.Add(i);

                }
            }

            return primes;
        }

        static int LargestPower(long num)
        {
            int i1 = 0;
            int largestPow = 1;

            while(true)
            {
                i1++;

                if(Math.Pow(num, i1) > 20)
                {
                    Console.WriteLine($"largest power for {num} is {i1 - 1}.");
                    return i1 - 1;
                }
                else
                {
                    largestPow = (int)Math.Pow(num, i1);
                }
            }
        }

        static void Main(string[] args)
        {
           
            List<long> primes = new List<long>() { 2,3,5,7,11,13,17,19 };
            List<long> largestPow = new List<long>();

            // find each highest ^ <= 20
            foreach(long n in primes)
            {
                largestPow.Add(LargestPower(n));
            }

            long total = 1;

            for(int i = 0; i < primes.Count;++i)
            {
                total *= (long)Math.Pow(primes[i], largestPow[i]);
            }

            Console.WriteLine(total);

        }
    }
}
