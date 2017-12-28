using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
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
                newNum = newNum * 10 + temp % 10;
                temp = temp / 10;
            }

            if (Num.Equals(newNum))
            {
                Console.WriteLine(Num + " is a palindrome number");
            }
            else
            {
                Console.WriteLine(Num + " is not a palindrome number");
            }

            Console.ReadKey();
        }
    }
}
