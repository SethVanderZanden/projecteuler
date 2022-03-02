using System.Collections.Generic;
using System;

namespace Challenge3
{
    class Program
    {
        public static List<long> FindPrimeNumbersUnderN(long n) {
            // between [2, sqrt(n) + 1]
            Console.WriteLine(Math.Sqrt(n + 1));
            List<long> primes = new List<long>();

            for(long i = 2; i < Math.Sqrt(n + 1); ++i) {
                if(i < Math.Sqrt(n + 1))
                {
                    if (n % i == 0)
                        primes.Add(i);

                }
            }

            return primes;
        }


        static void Main(string[] args)
        {
            long num = 600851475143;
            List<long> primeFactors = new List<long>();
            List<long> primeNums = FindPrimeNumbersUnderN(num);
            long solution = 1;
            for(int i = 0; i < num; ++i)
            {
                if(solution * primeNums[i] <= num)
                {
                    solution *= primeNums[i];
                    Console.WriteLine(primeNums[i]);
                }
                
            }
        }
    }
}
