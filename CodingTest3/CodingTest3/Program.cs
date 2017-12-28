using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest3
{
    class A
    {
        public A()
        {
            Console.WriteLine("I m in A Default");
        }
        public A(string name)
        {
            Console.WriteLine(name);
        }
    }

    class B : A
    {
        public B()
            : base("Gaurav") // USing Base Keyword, call the Base class Parameteried constructor
        {
            Console.WriteLine("I m in B Class Default");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            Console.ReadKey();
        }
    }
}
