using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
           for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();


        }
    }
}
