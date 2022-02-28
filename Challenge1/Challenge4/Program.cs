using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge4
{
    class Program
    {
        static List<long> CheckPalindrome(string num, int i1, int j1)
        {
            // convert to string
            // reverse string
            // return the comparison of the 2
            
            char[] charNum = num.ToCharArray();
            char[] charResult = new char[charNum.Length];
            List<long> allPalindromes = new List<long>();

            for(int i = charNum.Length - 1, j = 0; i > -1; --i, j++) {
                charResult[j] = charNum[i];
            }

            string reversed = new string(charResult);

            if(reversed == num)
            {
                //Console.WriteLine($"{reversed} : {num} : {i1} : {j1} Palindrome");
                allPalindromes.Add(long.Parse(num));
            }

            
            return allPalindromes;
        }

        // Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            // allPalindromes.OrderBy(i => i);
            List<long> allPalins = new List<long>();


            for (int i = 999; i > 99; i--)
            {
                for (int j  = 999; j > 99; j--)
                {
                    allPalins.AddRange(CheckPalindrome((i * j).ToString(), i, j));
                }
            }

            allPalins.Sort();

            Console.WriteLine(allPalins[allPalins.Count - 1]);
        }
    }
}
