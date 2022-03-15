using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Challenge
    {

        public static int GetSumsOfN(int n) {
            List<int> sums = new List<int>();
            int sum = 0;
            for(int i = 1; i < n; ++i) {
                if(n % i == 0) sums.Add(i);
            }

            foreach (int item in sums)
            {
                sum += item;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            /*
            Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
            If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

            For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

            Evaluate the sum of all the amicable numbers under 10000.
            */

            List<int> sums = new List<int>();
            List<int> ampicableSum = new List<int>();
            bool endLoop = false;

            for (int i = 1; i < 10000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0) {
                        sums.Add(j);
                        //if(i == 220) System.Console.WriteLine(j);
                    }
                }

                int tot = 0;

                foreach (int item in sums)
                {
                    tot += item;
                }

                sums = new List<int>();

                int sumOfTot = GetSumsOfN(tot);
                if(sumOfTot == i && sumOfTot != tot) {
                    ampicableSum.Add(sumOfTot);
                    ampicableSum.Add(tot);
                    if(tot > 10000) endLoop = true;
                    i = tot + 1;
                }

                if(endLoop) break;
            }

            int sumTotal = 0;

            foreach (int item in ampicableSum)
            {
                System.Console.WriteLine(item);
                sumTotal += item;
            }

            System.Console.WriteLine(sumTotal);
        }
    }
}