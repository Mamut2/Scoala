using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_String
{
    class Program
    {
        // R2

        public static bool EAnagrama(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            int[] f1 = new int[26];
            int[] f2 = new int[26];
            foreach(char c in s1) f1[c - 'a']++;
            foreach (char c in s2) f2[c - 'a']++;
            for (int i = 0; i < 26; i++) if (f1[i] != f2[i]) return false;
            return true;
        }

        public static int Vocale(string s)
        {
            int nr = 0;
            string voc = "aeiou";
            foreach (char c in s) if (voc.IndexOf(c) != -1) nr++;
            return nr;
        }

        public static string Oglindit(string s)
        {
            string res = "";
            for (int i = s.Length - 1; i >= 0; i--) res += s[i];
            return res;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine()), nr = 0;
            string[] cuvinte = s.Split();
            int last = cuvinte.Length - 1;

            while (last >= 0 && cuvinte[last] == "") last--;                                 // Elimina cuvintele goale de la sfarsit daca sunt
            for (int i = 0; i < last; i++) if (EAnagrama(cuvinte[i], cuvinte[last])) nr++;

            Console.WriteLine("Cate cuv sunt anagrame ale ultimului cuvant: " + nr);
            Console.Write("Indicele primului cuvant cu k vocale: ");

            bool ok = false;
            for (int i = 0; i < cuvinte.Length; i++)
            {
                int nrVoc = Vocale(cuvinte[i]);
                if (nrVoc == k)
                {
                    Console.WriteLine(i);
                    ok = true;
                    break;
                }
            }

            if (!ok) Console.WriteLine("Nu exista");
            Console.Write("Indicele ultimului cuvânt cu k consoane: ");

            ok = false;
            for (int i = cuvinte.Length - 1; i >= 0; i--)
            {
                int nrCon = cuvinte[i].Length - Vocale(cuvinte[i]);
                if (nrCon == k)
                {
                    Console.WriteLine(i);
                    ok = true;
                    break;
                }
            }

            if (!ok) Console.WriteLine("Nu exista");
            Console.WriteLine("Perechi oglindite: ");

            for (int i = 0; i < cuvinte.Length; i++)
            {
                for (int j = i + 1; j < cuvinte.Length; j++) 
                {
                    if (cuvinte[i] == Oglindit(cuvinte[j]) && cuvinte[i] != "")
                        Console.WriteLine(cuvinte[i] + ' ' + cuvinte[j]);
                }
            }
        }
    }
}
