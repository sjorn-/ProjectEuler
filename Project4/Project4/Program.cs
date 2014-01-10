using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 100;
            int max = 999;
            bool first = false;
            int curAns = 0;
            string answer = "";
            for (int i = max; i > min; i--)
            {
                for (int x = max; x > min; x--)
                {
                    //Console.WriteLine("x = " + x);
                    char[] check = (i * x).ToString().ToCharArray();
                    string revCheck = "";
                    for (int y = 0; y < check.Length; y++)
                    {
                        revCheck = check[y] + revCheck.ToString();
                    }
                    string original = (i * x).ToString();
                    //Console.WriteLine(original + " : " +  revCheck);
                    if (original == revCheck)
                    {
                        if ((i * x) > curAns)
                        {
                            first = true;
                            curAns = i * x;
                            answer = i.ToString() + " * " + x.ToString() + " = " + original;
                        }
                        //Console.WriteLine(original);
                        Console.WriteLine("i * x = " + i.ToString() + " * " + x.ToString() + " = " + (i * x).ToString());
                        //break;
                    }
                }
            }
            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
