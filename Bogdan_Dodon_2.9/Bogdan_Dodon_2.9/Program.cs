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
            int decim = int.Parse(Console.ReadLine());
            int ones = 0;

            while (decim > 0)
            {
                if (decim % 2 == 1)
                {
                    ones++;
                }
                decim = decim / 2;
            }
            Console.WriteLine(ones);
        }
    }
}