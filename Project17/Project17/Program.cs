using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberWords = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "thousand"};
            string totalString = "";
            for (int i = 0; i <= 999; i++)
            //int i = int.Parse(Console.ReadLine()) - 1;
            {
                string curAns = "";
                int nxtDigit, y = i + 1;
                char[] curNum = y.ToString().ToCharArray();
                while (y != 0)
                {
                    if (y <= 19)
                    {
                        curAns = curAns + numberWords[y - 1];
                        y = 0;
                    }
                    else if (curNum.Length == 2)
                    {
                        int x = y;
                        nxtDigit = (int)Math.Floor((double)(x/10));
                        curAns = curAns + numberWords[19 + (nxtDigit - 2)];
                        y = int.Parse(curNum[1].ToString());
                        /*if (y == 9)
                        {
                            y = 0;
                        }*/
                    }
                    else if (curNum.Length == 3)
                    {
                        int x = i + 1;
                        nxtDigit = (int)Math.Floor((double)(x / 100)) - 1;
                        curAns = numberWords[nxtDigit] + "hundred";
                        y = int.Parse(curNum[1].ToString() + curNum[2].ToString());
                        if (y != 0) {
                            curAns += "and";
                        }
                        curNum = y.ToString().ToCharArray();
                    }
                    else if (curNum.Length == 4)
                    {
                        int x = i + 1;
                        nxtDigit = (int)Math.Floor((double)(x / 1000)) - 1;
                        curAns = numberWords[nxtDigit] + "thousand";
                        y = int.Parse(curNum[1].ToString() + curNum[2].ToString() + curNum[3].ToString());
                        curNum = y.ToString().ToCharArray();
                    }
                }
                totalString += curAns;
                Console.WriteLine(curAns);
                curAns = "";
            }
            Console.WriteLine(totalString);
            Console.WriteLine(totalString.Length);
            Console.Read();
        }
    }
}
