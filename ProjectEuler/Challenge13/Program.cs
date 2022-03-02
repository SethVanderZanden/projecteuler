using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Challenge13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // read in the file
                string text = File.ReadAllText("../data.txt");
                // get rid of newline
                text = text.Replace("\n", "").Replace("\r", " ");
                // split by whitespace
                string[] arrayText = text.Split();

                List<BigInteger> numbers = new List<BigInteger>();

                // convert to list of nums
                foreach (string item in arrayText)
                {
                    numbers.Add(BigInteger.Parse(item));
                }

                BigInteger sum = 0;

                foreach(BigInteger n in numbers)
                {
                    sum += (BigInteger)n;
                }

                Console.WriteLine(sum);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*
            Console.WriteLine(arrayText.Length);

            foreach (var item in arrayText)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
