using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevi
{
    class Elev
    {
        public string nume, prenume, clasa;
        public bool sex;
        public bool bursier;
        public List<int> medii;
        public List<string> optionale;
        public double mediaGenerala;
        public DateTime dn;

        public Elev(string nume_prenume, string clasa, List<int> medii, bool sex, List<string> optionale, DateTime dn)
        {
            string[] s = nume_prenume.Split();
            this.nume = s[0];
            this.prenume = s[1];
            this.clasa = clasa;
            this.medii = medii.ToList();

            double suma = 0;
            foreach(int m in medii)
                suma += m;
            this.mediaGenerala = suma / medii.Count;

            this.sex = sex;
            this.bursier = (mediaGenerala >= 9.5);
            this.optionale = optionale.ToList();

            this.dn = dn;
        }
    }
}
