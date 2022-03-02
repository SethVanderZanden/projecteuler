using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge10
{
    class Program
    {
        static int FindNextPrime(List<NumberPrime> nums, int prevspot)
        {
            try
            {
                for (int i = prevspot + 1; i < nums.Count; ++i)
                {
                    if (nums[i].isPrime == true)
                        return i;
                }

                throw new Exception($"nothing found prevspot:{prevspot}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public struct NumberPrime
        {
            public int number;
            public bool isPrime;

            public NumberPrime(bool b, int n)
            {
                number = n;
                isPrime = b;
            }

            public override string ToString()
            {
                return $"Number: {number}\tisPrime{isPrime}";
            }
        }

        static void Main(string[] args)
        {
            /*
            algorithm Sieve of Eratosthenes is
            input: an integer n > 1.
            output: all prime numbers from 2 through n.

            let A be an array of Boolean values, indexed by integers 2 to n,
            initially all set to true.

            for i = 2, 3, 4, ..., not exceeding √n do
                if A[i] is true
                    for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n do
                        A[j] := false

            return all i such that A[i] is true.
            */

            List<NumberPrime> allInts = new List<NumberPrime>();
            long twoMill = 2000000;
            //long twoMill = 30;
            // setup
            for (int i = 0; i < twoMill; i++)
            {
                allInts.Add(new NumberPrime(true, i));
            }

            // start w 2, mark all false
            for(int i = 2; i < allInts.Count; i+=2)
            {
                allInts[i] = new NumberPrime(false, allInts[i].number);

            }

            int nextIncrement = 1;

            while(true)
            {
                nextIncrement = FindNextPrime(allInts, nextIncrement);
                if (nextIncrement == 0) break;

                for(int i = nextIncrement + nextIncrement; i < allInts.Count; i += nextIncrement)
                {
                    if(allInts[i].isPrime != false)
                        allInts[i] = new NumberPrime(false, allInts[i].number);
                }
            }

            int primes = allInts.Where(x => x.isPrime == true).Count();
            List<NumberPrime> primesList = allInts.Where(x => x.isPrime == true).ToList();
            Console.WriteLine(primes);
            ulong sum = 2;
            foreach(NumberPrime n in primesList)
            {
                sum += (ulong)n.number;
            }

            Console.WriteLine(sum - 1);
        }
    }
}
