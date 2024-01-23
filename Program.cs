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
            int[] arr = { 1, 2, 1, 4, 5, 5, 7, 4,};
            Array.Sort(arr);
            int n = arr.Length;
            int var = arr[0];
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] != var)
                {
                    Console.WriteLine(var);
                    var = arr[i];
                }
            }
            if (arr[n-1]!=var)
            {
                Console.WriteLine(var);
            }
            

            Console.ReadLine();


        }
    }
}
