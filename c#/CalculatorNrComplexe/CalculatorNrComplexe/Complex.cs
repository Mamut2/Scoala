using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorNrComplexe
{
    class Complex
    {
        int re, im;

        public int Re
        {
            set { re = value; }
            get { return re; }
        }

        public int Im
        {
            set { im = value; }
            get { return im; }
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex rez = new Complex();
            rez.re = a.re + b.re;
            rez.im = a.im + b.im;
            return rez;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex rez = new Complex();
            rez.re = a.re * b.re - a.im * b.im;
            rez.im = a.re * b.im + a.im * b.re; 
            return rez;
        }

        public double Modul()
        {
            return Math.Sqrt(re * re + im * im);
        }
    }
}
