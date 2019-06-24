using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "один два три один четыре пять";
            string[] separated = str.Split(new Char[] { ' ' });
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < separated.Length; i++)
            {
                if (dict.ContainsKey(separated[i]))
                {
                    dict[separated[i]] = dict[separated[i]] + 1;
                }
                else
                {
                    dict.Add(separated[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> keyValue in dict)
            {
                if (keyValue.Value == 1)
                {
                    Console.WriteLine(keyValue.Key);
                    Console.ReadKey();
                }

            }

        }
    }
}
