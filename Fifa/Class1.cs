using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    class csapat
    {
        public string Csapat { get; set; }
        public int Helyezes { get; set; }
        public int Valtozas{ get; set; }
        public int Pontszam { get; set; }

        public csapat (string sor)
        {
            string[] t = sor.Split(';');
            Csapat = t[0];
            Helyezes = int.Parse(t[1]);
            Valtozas = int.Parse(t[2]);
            Pontszam = int.Parse(t[3]);

        }
        
    }
}
