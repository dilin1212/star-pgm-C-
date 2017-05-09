using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamondpgm
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int number = 10;
                Console.Write("Enter number\n");
                number = int.Parse(Console.ReadLine());
                for (int i = number; i >= 0; i--)
                {
                    for (int n = 0; n < number; n++)
                    {
                        if (i > n)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }

        }
    }
}
