using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hajok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hajo> adatok = new List<Hajo>();
            foreach (var i in File.ReadAllLines("hajolista.csv"))
            { 
                Hajo x = new Hajo(i);
                adatok.Add(x);                
            }
            Console.WriteLine("4. feladat: Hajók száma: " + adatok.Count);

            foreach (var i in adatok)
            {
                if (i.Tipus == "személyhajó" & i.Varos != "Siófok")
                {
                    Console.WriteLine("5. feladat: Siófokon kívüli hajók:" + i.Nev);
                    Console.WriteLine(i.Kiemelt());
                    Console.WriteLine(i.Gyartas_eve);

                }
            }
            Console.Write("7. feladat: Kérem a város nevét: ");

            string varos = Console.ReadLine();

            int osszeg = 0;
            int db = 0;

            foreach (var i in adatok)
            {
                if (i.Varos == varos)
                {
                    osszeg += i.Gyartas_eve;
                    db++;
                }
            }

            if (db == 0)
            {
                Console.WriteLine("Nem található hajó a megadott városban.");
            }
            else
            {
                Console.WriteLine($"A hajók átlagos gyártási éve:  {osszeg / db }");
            }            
            Console.ReadKey();
        }
    }
}
