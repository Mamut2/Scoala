using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minmax
{
    class Program
    {
        static void minmax(int x, ref int max, ref int min)
        {
            int temp = x;
            while (x != 0)
            {
                max = Math.Max(max, x % 10);
                min = Math.Min(min, x % 10);
                x /= 10;
            }
        }

        static void Main(string[] args)
        {
            int x, min = 9, max = 0;
            x = int.Parse(Console.ReadLine());
            minmax(x, ref max, ref min);
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
