using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number=");
            int Num = Convert.ToInt32(Console.ReadLine());
            int temp = Num;
            int newNum = 0;

            while (temp > 0)
            {
                int val = temp % 10;
                newNum = newNum + (val * val * val);
                temp = temp / 10;
            }

            if (Num.Equals(newNum))
            {
                Console.WriteLine(Num + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine(Num + " is not an Armstrong number");
            }
            Console.ReadKey();
        }
    }
}
