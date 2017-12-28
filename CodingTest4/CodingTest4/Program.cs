using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            Check_Pelindrome_Word();
            //  CountSpace_ASCII_CHAR();

            // replace_is_with_at();
            Console.ReadLine();
        }
        private static void replace_is_with_at()
        {
            string str = "This is a black cat.";
            string newStr = "";
            char[] chr = str.ToCharArray();
            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] == 'i' && chr[i + 1] == 's')
                {
                    chr[i] = 'a';
                    chr[i + 1] = 't';
                }
                newStr = newStr + chr[i];
            }
            Console.WriteLine(newStr);
        }

        private static void CountSpace_ASCII_CHAR()
        {
            string str = "This is a black cat.";
            //string str = "Aa";
            char[] chr = str.ToCharArray();
            int count = 0;
            foreach (char ch in chr)
            {
                if (ch == ' ')
                {
                    count = count + 1;
                }

                // Console.WriteLine(Convert.ToInt32(ch)); // get ASCII value by char
                // Console.WriteLine(Convert.ToChar(count)); //get Char by ASCII value
            }

            Console.Write("Number of Space =" + count);
        }

        private static void Check_Pelindrome_Word()
        {
            Console.WriteLine("Enter Word to chrck Pelidrom or Not=");
            string str = Console.ReadLine().ToLower();
            char[] a = str.ToCharArray();
            string newStr = "";
            Array.Reverse(a);
            newStr = new string(a);

            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    newStr = newStr + a[i];
            //}
            if (str.Equals(newStr, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("This word is Pelindrom");
            }
            else
            {
                Console.WriteLine("This word is not Pelindrom");
            }
        }
    }
}
