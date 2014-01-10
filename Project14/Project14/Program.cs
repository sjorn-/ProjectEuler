using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 length = 0;
            Int64 biggestLength = 0;
            Int64 startNum = 0;
            for (int i = 2; i < 1000000; i++)
            {
                //Int64 i = 10;
                Int64 x = i;
                Int64 y = x;
                //Console.WriteLine(x);
                while (x != 1)
                {
                    if (x % 2 == 0)
                    {
                        y = x / 2;
                    }
                    else
                    {
                        y = (3*x) + 1;
                    }
                    length++;
                    x = y;
                    //Console.WriteLine(x);
                }
                //Console.WriteLine(length + "\n");
                //if (i % 2 == 1)
                {
                    length+=1;
                }
                if (length > biggestLength)
                {
                    biggestLength = length;
                    startNum = i;
                }
                length = 0;
            }
            Console.WriteLine(startNum);
            Console.Read();
        }
    }
}
