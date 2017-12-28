using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 7, 1, 8 };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
