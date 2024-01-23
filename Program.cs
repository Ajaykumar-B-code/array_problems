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
            int[,] a = { { 1, 2, 3 },
                          { 4, 5,7 } };
            int sum = 0;
            for (int i = 0;i < a.GetLength(0) ; i++)
            {
               
                for (int j=0;j< a.GetLength(1) ; j++)
                {
                    
                    sum += a[i,j];
                    
                }
                Console.WriteLine($"The sum of the row {i} is {sum}");

            }
            Console.ReadLine();


        }

        
    }
}
