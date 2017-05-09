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
                for (int i = 15; i >= 0; i--)
                {
                    for (int n = 0; n < 15; n++)
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
