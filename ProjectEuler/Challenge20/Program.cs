using System;
using System.Linq;
using System.Numerics;

namespace Program {
    class Challenge19 {
        public static void Main(string[] args) {
            BigInteger bi = 1;

            for(int i = 1; i < 100; ++i) {
                bi *= i;
            }

            //System.Console.WriteLine(bi);
            string s = bi.ToString();
            long sum = 0;
            foreach(char c in s) {
                sum += (long)Char.GetNumericValue(c);
            }

            System.Console.WriteLine(sum);
        }
    } 
}