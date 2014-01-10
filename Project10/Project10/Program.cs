using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 num = 2000000;
            Int64 total = 0;
            if (num % 2 == 0)
            {
                num--;
            }
            for (Int64 i = num; i > 1; i-=2)
            {
                bool prime = true;
                if (i % 2 == 0)
                {
                    prime = false;
                }
                for (Int64 x = 3; x < Math.Ceiling(Math.Sqrt(i)) + 1; x += 2)
                {
                    if (i % x == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    total += i;
                    Console.WriteLine(i);
                }
            }
            total += 2;
            Console.WriteLine(total);
            Console.Read();//142913828922
        }
    }
}
