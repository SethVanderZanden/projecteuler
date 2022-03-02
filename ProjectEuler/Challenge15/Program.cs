using System;

namespace Challenge15
{
    class Program
    {
        static void Main(string[] args)
        {
            const int grid = 20;
            long answer = 1;

            for (int i = 0; i < grid; i++)
            {
                answer *= (2 * grid) - i;
                answer /= i + 1;
            }

            Console.WriteLine(answer);

        }
    }
}
