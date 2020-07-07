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
            for (a = 1; a <= x; a++)
            {
                for (i = 1; i <= (x - a); i++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * a) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (b = 1; b <= x - 1; b++)
            {
                for (m = 1; m <= x - (x - b); m++)
                {
                    Console.Write(" ");
                }
                for (n = 1; n <= ((2*x)-1)-(2*b); n+=1)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
