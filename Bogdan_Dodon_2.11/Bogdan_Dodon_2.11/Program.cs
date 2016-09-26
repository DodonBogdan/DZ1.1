using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan_Dodon_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the binary value:");
            string s = Console.ReadLine();
            int b = Convert.ToInt32(s, 2);
            Console.WriteLine("The value in base 10 is: " + b);
        }
    }
}
