using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool small = false;
            while (!small)
            {
                i++;
                small = true;
                for (int x = 1; x <= 20; x++)
                {
                    if (i % x != 0)
                    {
                        small = false;
                    }
                }
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
