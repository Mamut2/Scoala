using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase_dif
{
    class Angajat
    {
        public string nume, prenume, departament;
        double venit;
        public DateTime dn;

        public Angajat(string nume, string prenume, string departament, double venit, DateTime dn)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.departament = departament;
            this.venit = venit;
            this.dn = dn;
        }
    }
}
