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
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(n > 0)
            {
                int digit=n%10;
                sum += digit;
                n /= 10;
            }
            Console.WriteLine($"the sum of the digit in the number is {sum}");
            Console.ReadLine();


        }

        
    }
}
