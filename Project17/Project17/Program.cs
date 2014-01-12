using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project17
{
    class Program
    {
        static string[] numberWords = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand" };

        static string nextNumber(int i)
        {
            string curAns = "";
            if (i <= 19)
            {
                if (i == 0)
                {
                    return "";
                }
                return numberWords[i - 1];
            }
            else if (i > 19 && i < 100)
            {
                return numberWords[17 + i / 10] + nextNumber(i % 10);
            }
            else if (i > 99 && i < 1000)
            {
                int y = i / 100;
                curAns = numberWords[y - 1] + "hundred";
                if (y * 100 != i)
                {
                    curAns += "and";
                }
                return curAns + nextNumber(i % 100);
            }
            else if (i == 1000)
            {
                return "onethousand";
            }
            return curAns;
        }
        
        static void Main(string[] args)
        {
            string totalString = "";
            for (int i = 1; i <= 1000; i++)
            //int i = int.Parse(Console.ReadLine());
            {
                totalString += nextNumber(i);
            }
            //Console.WriteLine(totalString);
            Console.WriteLine(totalString.Length);
            Console.Read();
        }
        
    }
}
