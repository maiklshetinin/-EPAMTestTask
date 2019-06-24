using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            Console.WriteLine("Initial");
            for (int write = 0; write < arr.Length; write++)
            {
                Console.Write("{0} ", arr[write]);
            }
            arr = Sort(arr);
            Console.WriteLine("Result");
            for (int write = 0; write < arr.Length; write++)
            {
                Console.Write("{0} ", arr[write]);
                Console.ReadKey();
            }

        }

        private static int[] Sort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            return arr;
        }
    }
}