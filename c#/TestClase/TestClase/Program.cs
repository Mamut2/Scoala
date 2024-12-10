using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClase
{
    class Program
    {
        class NR_COMPLEX
        {
            private int re = 0, im = 0;

            public NR_COMPLEX() { }

            public NR_COMPLEX(int re, int im)
            {
                this.re = re;
                this.im = im;
            }

            public void Afisare()
            {
                Console.WriteLine(re.ToString() + " + " + im.ToString() + " * i");
            }

            public bool EInPrimulCadran()
            {
                if (re > 0 && im > 0) return true;
                return false;
            }

            public double Modul()
            {
                return Math.Sqrt(re * re + im * im);
            }

            public static NR_COMPLEX operator +(NR_COMPLEX x, NR_COMPLEX y)
            {
                return new NR_COMPLEX(x.re + y.re, x.im + y.im);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NR_COMPLEX[] a = new NR_COMPLEX[n];
            NR_COMPLEX sum = new NR_COMPLEX();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(); // Se citesc ambele parti ale numarului complex pe o linie (re im)

                int re = int.Parse(s[0]), im = int.Parse(s[1]);

                a[i] = new NR_COMPLEX(re, im);
                sum += a[i];
            }
            Console.WriteLine("Suma numerelor este: ");
            sum.Afisare();

            Console.WriteLine("Numerele din primul cadran: ");
            for (int i = 0; i < n; i++)
                if(a[i].EInPrimulCadran())
                    a[i].Afisare();

            Console.WriteLine("Numerele afisate in ordine crescatoare dupa modulul lor: ");
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(a[i].Modul() > a[j].Modul())
                    {
                        NR_COMPLEX tmp = a[i];                 // Sortare crescatoare dupa modul
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            for(int i = 0; i < n; i++)
                a[i].Afisare();
            Console.ReadKey();
        }
    }
}
