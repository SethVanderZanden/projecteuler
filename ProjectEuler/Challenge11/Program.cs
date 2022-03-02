using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Challenge11
{
    class Program
    {
        static long LargestProductHorizontal(int[,] nums)
        {
            try
            {
                int x = 0;
                int y = 0;
                List<long> product = new List<long>();

                while(y < 20)
                {
                    product.Add(nums[x, y] * nums[x + 1, y] * nums[x + 2, y] * nums[x + 3, y]);

                    // reset after 16 
                    if (x == 15)
                    {
                        x = -1;
                        y++;
                    }

                    x++;
                }

                //Console.WriteLine(product[product.Count - 1]);
                product.Sort();
                Console.WriteLine(product[product.Count - 1]);
                return product[product.Count - 1];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        static long LargestProductVertical(int[,] nums)
        {
            try
            {
                int x = 0;
                int y = 0;
                List<long> product = new List<long>();

                while (y < 16)
                {
                    product.Add(nums[x, y] * nums[x, y + 1] * nums[x, y + 2] * nums[x, y + 3]);

                    // reset after 16 
                    if (x == 19)
                    {
                        x = -1;
                        y++;
                    }

                    x++;
                }

                //Console.WriteLine(product[product.Count - 1]);
                product.Sort();
                Console.WriteLine(product[product.Count - 1]);
                return product[product.Count - 1];

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        // between y 4..16 start at x shape where x between 4..16
        static long LargestProductDiagonal(int[,] nums)
        {
            try
            {
                int x = 0;
                int y = 4;
                List<long> product = new List<long>();

                while(y < 17)
                {

                    // can only go diagonal to the right
                    if(x < 4)
                    {
                        product.Add(nums[x, y] * nums[x + 1, y - 1] * nums[x + 2, y - 2] * nums[x + 3, y - 3]);
                        product.Add(nums[x, y] * nums[x + 1, y + 1] * nums[x + 2, y + 2] * nums[x + 3, y + 3]);
                    }

                    // can only go diagonal to the left
                    else if(x > 16)
                    {
                        product.Add(nums[x, y] * nums[x - 1, y - 1] * nums[x - 2, y - 2] * nums[x - 3, y - 3]);
                        product.Add(nums[x, y] * nums[x - 1, y + 1] * nums[x - 2, y + 2] * nums[x - 3, y + 3]);
                    }

                    // can go diagonal to the left and the right
                    else
                    {
                        product.Add(nums[x, y] * nums[x + 1, y - 1] * nums[x + 2, y - 2] * nums[x + 3, y - 3]);
                        product.Add(nums[x, y] * nums[x + 1, y + 1] * nums[x + 2, y + 2] * nums[x + 3, y + 3]);
                        product.Add(nums[x, y] * nums[x - 1, y - 1] * nums[x - 2, y - 2] * nums[x - 3, y - 3]);
                        product.Add(nums[x, y] * nums[x - 1, y + 1] * nums[x - 2, y + 2] * nums[x - 3, y + 3]);
                    }
                   
                    // after ea loop
                    if(x == 19)
                    {
                        x = -1;
                        y++;
                    }

                    x++;
                }

                //Console.WriteLine(product[product.Count - 1]);
                product.Sort();
                Console.WriteLine(product[product.Count - 1]);
                return product[product.Count - 1];

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            // read in the file
            string text = File.ReadAllText("../data.txt");
            // get rid of newline
            text = text.Replace("\n", "").Replace("\r", " ");
            // split by whitespace
            string[] arrayText = text.Split();

            Console.WriteLine(arrayText.Length);

            int[,] numberGrid = new int[20,20];
            int x = 0;
            int y = 0;
            try
            {
                for (int i = 0; i < arrayText.Length; i++)
                {
                    numberGrid[x, y] = Int32.Parse(arrayText[i]);
                    // reset and go to next row
                    if (x == 19)
                    {
                        x = -1;
                        y++;
                    }

                    if(y == 20)
                    {
                        break;
                    }

                    x++;

                   
                }


                LargestProductHorizontal(numberGrid);
                LargestProductVertical(numberGrid);
                LargestProductDiagonal(numberGrid);

            }
            catch(Exception e)
            {
                Console.WriteLine($"{x}, {y}");
                Console.WriteLine(numberGrid[19,19]);
                Console.WriteLine(e.Message);
            }
           


        }
    }
}
