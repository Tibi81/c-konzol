using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hajok
{
    internal class Hajo
    {
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public int Gyartas_eve { get; set; }
        public int Uzemel { get; set; }
        public string Tulajdonos { get; set; }
        public string Varos { get; set; }

        public Hajo(string sor)
        {
            string[] resz = sor.Split(';');
            Nev = resz[0];
            Tipus = resz[1];
            Gyartas_eve = int.Parse(resz[2]);
            Uzemel = int.Parse(resz[3]);    
            Tulajdonos = resz[4];
            Varos = resz[5];
        }

        public bool Kiemelt()
        {
            if (Gyartas_eve < 1990)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
