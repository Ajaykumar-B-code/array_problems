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
            int maxnum = arr[0];
            int minnum = arr[0];
            for(int i=0;i<arr.Length; i++) 
            {
                if (arr[i] > maxnum)
                {
                    maxnum = arr[i];
                }
                if (arr[i]<minnum)
                {
                    minnum = arr[i];
                }
            }
            Console.WriteLine("Maximum number :" + maxnum);
            Console.WriteLine("Minimum number : " + minnum);


            Console.ReadLine();


        }
    }
}
