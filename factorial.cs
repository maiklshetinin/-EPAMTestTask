using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9

{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write(" ");
            string input = Console.ReadLine();
            int f = Int32.Parse(input);
            if (f >= 0)
            {
                long result = Factorial(f);
                Console.WriteLine("факториал");
                Console.WriteLine(result);
            }


            Console.ReadKey();
        }

        public static long Factorial(int f)
        {
            long factotial = 1;
            if (f != 0)
            {
                for (int i = 2; i <= f; i++)
                {
                    factotial *= i;
                }
            }
            return factotial;
        }
    }
}
