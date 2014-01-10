using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0, b = 0, c = 0;
            double answer = 0;
            for (int a = 5; a < 500; a++)
            {
                for (int b = 5; b < 500; b++)
                {
                    double c = Math.Sqrt((a * a) + (b * b));
                    if (a + b + c == 1000)
                    {
                        answer = a * b * c;
                    }
                }
            }
            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
