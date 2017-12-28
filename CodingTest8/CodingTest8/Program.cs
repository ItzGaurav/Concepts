using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest8
{
    // Method Hiding is a mecanism to hide an existing method by new method.
    //Child class hide the base class method.
    class BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Base/Parent Class Method Call");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Show()   // Use New Keyword used for Meethod Hiding
        {
            Console.WriteLine("Derived/Child Class Method Call");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Show();
            Console.ReadKey();

        }
    }
}
