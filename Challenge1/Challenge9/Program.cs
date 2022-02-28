using System;

namespace Challenge9
{
    /*
     A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

    a2 + b2 = c2
    For example, 32 + 42 = 9 + 16 = 25 = 52.

    There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    Find the product abc.

    a = k * (pow(m,2) - pow(n,2))        
    b = k * (2mn)       
    c = k * (pow(m,2) + pow(n,2)

    a = m^2 - n^2 
    b = 2(mn)
    c = m^2 + n^2

    That these formulas generate Pythagorean triples can be verified by expanding a2 + b2 using elementary algebra and verifying that the result equals c2. 
    Since every Pythagorean triple can be divided through by some integer k to obtain a primitive triple, every triple can be generated uniquely by using the formula with m 
    and n to generate its primitive counterpart and then multiplying through by k as in the last equation.

     */

    class Program
    {
        static void Main(string[] args)
        {
            int t = 1000;
            double a = 0;
            double b = 0;
            double c = 0;

            for(double m = 499.0; m > 0.0; m-=1.0)
            {
                for(double n = 499.0; n > 0.0; n-=1.0)
                {
                    a = Math.Pow(m, 2) - Math.Pow(n, 2);
                    b = 2 * (m * n);
                    c = Math.Pow(m, 2) + Math.Pow(n, 2);

                    if (a < 1000 && b < 1000 && c < 1000 && a > 0 && b > 0 && c > 0)
                        if (a + b + c == 1000)
                        {
                            Console.WriteLine(a * b * c);
                            Console.WriteLine($"a:{a}\tb:{b}\tc:{c}");
                        }
                            
                }
            }

        }
    }
}
