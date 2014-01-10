using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{
    class Program
    {
        static Int64 divisorCounter(Int64 i)
        {
            Int64 divisorCount = 2;
            //for (int x = 2; x <= /*triNum/**/(int)Math.Ceiling((double)(i / 2)); x++)
            for (int x = 2; x <= /*triNum/**/Math.Round(Math.Sqrt(i)); x++)
            {
                if (i % x == 0)
                {
                    divisorCount+=2;
                }
            }
            return divisorCount;
        }

        static void Main(string[] args)
        {
            Int64 i = 0;
            Int64 triNum = 0;
            //Int64 triNum = (i * (i + 1)) / 2;
            //Console.WriteLine(triNum);
            Int64 numDivisors = 0;
            //int divisorCount = 0;
            //DateTime newDate = new DateTime();
            while (numDivisors <= 500)
            {
                i++;
                triNum += i;
                //newDate = DateTime.Now;
                numDivisors = divisorCounter(triNum);       
                //Console.WriteLine(DateTime.Now - newDate);
                //onsole.WriteLine(triNum + " : " + numDivisors);
            }
            
            Console.WriteLine(triNum + " : " + numDivisors);
            Console.Read();
        }
    }
}
