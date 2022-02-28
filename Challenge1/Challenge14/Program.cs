using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge14
{
    class Program
    {
        /*
            The following iterative sequence is defined for the set of positive integers:

            n → n/2 (n is even)
            n → 3n + 1 (n is odd)

            Using the rule above and starting with 13, we generate the following sequence:

            13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

            Which starting number, under one million, produces the longest chain?

            NOTE: Once the chain starts the terms are allowed to go above one million.
         */
        struct ChainResult
        {
            public long number;
            public long chain;

            public ChainResult(long n, long c)
            {
                number = n;
                chain = c;
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                List<ChainResult> chainResults = new List<ChainResult>();
                long chainNumber = 0;
                long chain = 0;

                for (int i = 1000000; i > 0; i--)
                {
                    long n = i;
                    chainNumber = i;
                    chain = 0;

                    while (n != 1)
                    {
                        //  n → n/2 (n is even)
                        if (n % 2 == 0)
                        {
                            n = n / 2;
                        }
                        // n → 3n + 1 (n is odd)
                        else
                        {
                            n = (3 * n) + 1;
                        }

                        chain++;
                    }

                    if (n != 1)
                        throw new Exception("should not happen");

                    chainResults.Add(new ChainResult(chainNumber, chain));
                }

                chainResults = chainResults.OrderBy(x => x.chain).ToList();

                Console.WriteLine(chainResults[chainResults.Count - 1].number);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
