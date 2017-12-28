using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int xxx = 4;
                int z = i;

                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        z = z + xxx;
                        Console.Write(" " + z);
                        xxx--;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
