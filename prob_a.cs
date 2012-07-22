using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var c = Console.ReadLine();
            if (c.EndsWith("."))
            {
                c = c.Substring(0, c.Length - 1);
            }
            var inp = c.Split(' ');
            int res = 0;
            string[] taka = { "TAKAHASHIKUN", "Takahashikun", "takahashikun" };
            foreach (var t in inp)
            {
                foreach (var n in taka)
                {
                    if (t == n)
                    {
                        res++;
                    }
                }
            }
 
            Console.WriteLine(res);
        }
    }
}