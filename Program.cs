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
            int[] arr = { 1, 3, 2, 1, 1,2 };
            Array.Sort(arr);
            int duplicate_count = 0;
            for (int i=0;i<arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    duplicate_count++;
                }
            }
            Console.WriteLine(duplicate_count);
            Console.ReadLine();


        }
    }
}
