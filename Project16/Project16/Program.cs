using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project16
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 bigNum = 2;
            string num = Math.Pow(2, 1000).ToString();
            for (int x = 1; x < 1000; x++)
            {
                bigNum *= 2;
            }
            Console.WriteLine(bigNum);
            Console.Read();
        }
    }
}
