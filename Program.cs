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
            string sentance = "Hello world!";
            string temp = "";
            for (int i = 0;i<sentance.Length ;i++)
            {
                
                temp += sentance[i];
                char c = sentance[i];
                if (c == ' ') 
                {
                    Console.Write(reverse(temp));
                    Console.Write(" ");
                    temp = "";
                }
            }
            Console.WriteLine(reverse(temp));
            
            

            Console.ReadLine();


        }

        static string reverse(string s)
        {
            char[] temp = s.ToCharArray();

            string ReverseString = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                ReverseString += temp[i];
            }
          
            return ReverseString;
        }
    }
}
