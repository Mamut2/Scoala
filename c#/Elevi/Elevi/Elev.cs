using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevi
{
    class Elev
    {
        string nume, cls;
        int varsta;
        double media;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Clasa
        {
            get { return cls; }
            set { cls = value; }
        }
    }
}
