using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[] array = { 12, 45, 23, 3, 67, 43 };
            Array.Sort(array);
            string search = Console.ReadLine();
            int num = Int32.Parse(search);
            bool result = Array.Exists(array, element => element == num);
            {
                if (result)
                {
                    Console.WriteLine("Массив содержит искомое число");
                }
                else
                {
                    Console.WriteLine("Массив не содержит искомое число");
                    Console.ReadKey();
                }
            }

        }


    }
}