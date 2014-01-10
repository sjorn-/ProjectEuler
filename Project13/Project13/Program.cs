using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Numbers.txt");
            List<double> numbers = new List<double>();
            foreach (string line in lines)
            {
                numbers.Add(double.Parse(line));
            }
            double total = numbers.Sum();
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
