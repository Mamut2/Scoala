using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CitiriAfisari
{
    class Program
    {

        static int log_pow(int a, int b)
        {
            int res = 1;
            while (b > 0)
            {
                if (b % 2 == 1) res *= a;
                a *= a;
                b >>= 1;
            }
            return res;
        }

        static void Main(string[] args)
        {
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = log_pow(x, y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
