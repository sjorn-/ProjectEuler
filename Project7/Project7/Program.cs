using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeIndex = 2;
            int curPrime = 0;
            bool prime = true;
            //for (int i = 3; i <= 13; i += 2)
            int i = 3;
            while (primeIndex < 10001)
            {
                i += 2;
                int rootNum = (int)Math.Ceiling(Math.Sqrt(i));
                for (int x = 2; x <= rootNum; x++)
                {
                    if (i % x == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primeIndex++;
                    curPrime = i;
                    //Console.WriteLine(curPrime);
                }
                prime = true;
            }
            Console.WriteLine(curPrime);
            Console.Read();
        }
    }
}
