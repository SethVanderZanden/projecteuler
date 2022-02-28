using System;

namespace Challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumOfSquares = 0;
            int maxNum = 101;

            for(int i = 1; i < maxNum; ++i)
            {
                sumOfSquares += (long)Math.Pow(i, 2);
            }

            Console.WriteLine(sumOfSquares);
            long squareOfSum = 0;
            for(int i = 1; i < maxNum;++i)
            {
                squareOfSum += i;
            }

            squareOfSum = (long)Math.Pow(squareOfSum, 2);

            Console.WriteLine(sumOfSquares - squareOfSum);

        }
    }
}
