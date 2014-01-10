using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c;
            int total = 2;
            int max = 4000000;
            while (b < max)
            {
                c = a + b;
                a = c + b;
                b = c + a;
                if (c % 2 == 0 && c < max)
                {
                    total += c;
                }
                if (a % 2 == 0 && a < max)
                {
                    total += a;
                }
                if (b % 2 == 0 && b < max)
                {
                    total += b;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
