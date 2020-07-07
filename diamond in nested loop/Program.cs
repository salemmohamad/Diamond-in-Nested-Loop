using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond_in_nested_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number ");
            int x = int.Parse(Console.ReadLine());
            int a, b, i, j,m,n;


            // print the first half of the shape x rows
            for (a = 1; a <= x; a++)
            {
                //the space at first
                for (i = 1; i <= (x - a); i++)
                {
                    Console.Write(" ");
                }
                //then the stars
                for (j = 1; j <= (2 * a) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" "); //for new line after the loops in the row finish
            }

            // print the lower half of the shape x-1 rows
            for (b = 1; b <= x - 1; b++)
            {
                //the space at first
                for (m = 1; m <= x - (x - b); m++)
                {
                    Console.Write(" ");
                }
                //then the stars
                for (n = 1; n <= ((2*x)-1)-(2*b); n+=1)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" "); //for new line after the loops in the row finish
            }

            Console.ReadKey();
        }
    }
}
