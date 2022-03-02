using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Challenge16
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

                What is the sum of the digits of the number 2^1000? */

            // get the answer
            BigInteger sum = (BigInteger)Math.Pow(2, 1000);

            // convert to string
            string sumString = sum.ToString();

            // answer we will need
            BigInteger answer = 0;

            // get each char and convert to bigint
            foreach(char c in sumString)
            {
                answer += (BigInteger)Char.GetNumericValue(c);
            }

            // final answer
            Console.WriteLine(answer);
        }

    }
}
