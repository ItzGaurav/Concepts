using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest7
{
    //A class have multiple method with  same name but different Signature.
    class BaseClass
    {
        public void Add(int a, int b)
        {
            int Sum = a + b;
            Console.WriteLine("(First Method) Sum=" + Sum);
        }

        public void Add(int a, double b)  // Signature Change
        {
            double Sum = a + b;
            Console.WriteLine("(Second Method) Sum=" + Sum);
        }
        public void Add(int a, int b, int c)
        {
            int Sum = a + b + c;
            Console.WriteLine("(Third Method) Sum=" + Sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
            obj.Add(1, 4);
            //obj.Add(1, 4.1);
            obj.Add(1, 4, 5);

            Console.ReadKey();
        }
    }
}
