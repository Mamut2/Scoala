using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prefix_si_sufix
{
    class Program
    {
        /**Prefixe 1
         * 
         * refacut
         * r
         * re
         * ...
         **/
        static void Af1(string s)
        {
            for (int i = 1; i <= s.Length; i++)
            {
                Console.WriteLine(s.Substring(0, i));
            }
        }

        static void Af2(string s)
        {
            for (int i = s.Length; i > 0; i--)
            {
                Console.WriteLine(s.Substring(0, i));
            }
        }

        static void Sf1(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s.Substring(i, s.Length - i));
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s.Substring(i, s.Length - i));
            }
        }
    }
}
