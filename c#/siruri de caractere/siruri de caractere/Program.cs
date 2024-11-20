using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace siruri_de_caractere
{
    class Program
    {

        // Se da un text in care cuvintele sunt separate prin spatii. Se cere sa se transforme ultima litera din fiecare cuvant in litera mare sau sa ramana neschimbata
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s += " ";
            int sp = s.IndexOf(' ');
            while (sp != -1)
            {
                if (sp > 0 && s[sp - 1] >= 'a' && s[sp - 1] <= 'z')
                {
                    s = s.Substring(0, sp - 1) + char.ToUpper(s[sp - 1]) + s.Substring(sp);
                }
                sp = s.IndexOf(' ', sp + 1);
            }
            Console.WriteLine(s);
        }
    }
}
