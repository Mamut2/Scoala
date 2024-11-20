using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cifre
{
    class Program
    {
        // n1 cu cif pare n2 cu cif impare n1

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), n1 = 0, n2 = 0, p = 1, temp;
            temp = n;
            while (temp > 0)
            {
                if (temp % 2 == 0) { n1 += temp % 10 * p; p *= 10; }
                temp /= 10;
            }
            temp = n;
            while (temp > 0)
            {
                if (temp % 2 == 1) n2 = n2 * 10 + temp % 10;
                temp /= 10;
            }
            Console.WriteLine("{0} {1}", n1, n2);
            Console.ReadKey();
        }
    }
}
