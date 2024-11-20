using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fin = new StreamReader("date.in");
            StreamWriter fout = new StreamWriter("date.out");
            string s = fin.ReadLine();
            int nr = int.Parse(fin.ReadLine());
            fout.WriteLine(s + " " + nr);
            fin.Close();
            fout.Close();
        }
    }
}
