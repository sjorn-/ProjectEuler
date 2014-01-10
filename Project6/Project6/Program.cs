using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            int sumSquares = 0;
            int squareSum = 0;
            int answer = 0;
            for (int i = 1; i <= max; i++)
            {
                sumSquares += i * i;
                squareSum += i;
            }
            squareSum = squareSum * squareSum;
            answer = squareSum - sumSquares;
            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
