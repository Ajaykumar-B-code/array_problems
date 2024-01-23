using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 1, 2, 3, 9, 3, 6, 2, 8, 2, 9 };
            Array.Sort(a);
            int count = 0, variable = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (variable == a[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{variable} : {count}");
                    count = 1;
                    variable = a[i];
                }
            }
            Console.WriteLine($"{variable} : {count}");

            Console.ReadLine();


        }

        
    }
}
