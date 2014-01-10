using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        /*public bool checkPrime(int x)
        {
            for (int i = x - 1; i > 0; i--)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }*/
        
        static void Main(string[] args)
        {
            Int64 num = 600851475143;
            Int64 highPrime = 0;
            for (Int64 i = (int)Math.Ceiling(Math.Sqrt(num)) - 1; i > 1; i--)
            {
                bool prime = true;
                for (Int64 x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        prime = false;
                    }
                }
                /*if (prime)
                {
                    Console.WriteLine(i);
                }*/
                if ((prime) && (num % i == 0))
                {
                    highPrime = i;
                    Console.WriteLine(highPrime);
                    Console.ReadLine();
                }
            }
            Console.WriteLine(highPrime);
            Console.ReadLine();
        }

        
    }
}
