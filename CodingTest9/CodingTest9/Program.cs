using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest9
{
    // Overriding enables use to invoke derive class method using Base calss refrence verible at run time.
    //A Base class refrence varible can point child class object.
    class BaseClass
    {
        public virtual void Show() //Virtul Keyword is use
        {
            Console.WriteLine("Base Class Show Method is call");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Show() // Override Keyword is used
        {
            Console.WriteLine("Derive Class Show Method is call");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new DerivedClass();
            obj.Show();
            Console.ReadKey();
        }
    }
}
