using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cuv
{
    class Program
    {
        // Nr si litere mici, nr sunt reale poz cu partea intreaga si cea zecimala desp prin virg sau numai parte intreaga
        // Se afiseaza pe ecran nr de valori intregi din text

        static void Main(string[] args)
        {
            string s = " ";
            s += Console.ReadLine();
            s += " ";
            int sp = s.IndexOf(' '), nr = 0;
            while (sp != -1)
            {
                int ep = s.IndexOf(' ', sp + 1);
                if (ep == -1) break;
                if (s.Substring(sp, ep - sp + 1).IndexOf(',') == -1 && ep - 1 >= 0 && char.IsDigit(s[ep - 1])) nr++;
                sp = s.IndexOf(' ', sp + 1);
            }
            Console.WriteLine(nr);
        }
    }
}
