﻿using System;
using System.Collections.Generic;

namespace Challenge2
{
    class Program
    {
        /*
        Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
        By starting with 1 and 2, the first 10 terms will be:

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
        find the sum of the even-valued terms.
         */

        static void Main(string[] args)
        {
            const long MAX = 4000000;
            List<long> numbers = new List<long>() { 1, 2};
            int cIndex = 1;
            long sum = 0;
            int pIndex = 0;

            while(numbers[numbers.Count - 1] < MAX)
            {
                numbers.Add(numbers[cIndex] + numbers[pIndex]);
                cIndex++; 
                pIndex++;
            }

            numbers.RemoveAt(numbers.Count - 1);
            
            for(int i = 0; i < numbers.Count; ++i)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
