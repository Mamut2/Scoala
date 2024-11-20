using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace feline
{
    class Paralelogram
    {
        protected int lungime, latime;
        private int inaltime;
        public int aria(int baza, int h)
        {
            int a = baza * h;
            return a;
        }
        public void afis_propr()
        {
            Console.WriteLine("laturile opuse sunt paralele si =2 cate 2");
        }

        public Paralelogram(int lungime,int latime,int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }
    }

    class Dreptunghi : Paralelogram
    {
        public void afis_propr()
        {
            Console.WriteLine("unhi dreptunghi");
        }

        public Dreptunghi(){

        }
    }

    class Dreptunghi : Patrat
    {
        public Dreptunghi(int lungime,int latim

        public void afis_propr()
        {
            Console.WriteLine("unhi drept");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paralelogram p = new Paralelogram(25, 15, 3);
            Console.WriteLine(p.aria(25, 3))
        }
    }
}