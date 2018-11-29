using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2_Preduzece
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompanija kek = new Kompanija("KEK", 100000);
            kek.DodajKamion(new Kamion("Scania 2", 500, 3));
            kek.DodajKamion(new Kamion("Scania 1", 1000, 1));
            Console.WriteLine("Stanje {0} je {1}", kek.Naziv, kek.Budzet);
            kek.DodajKamion(new Kamion("Scania 3", 1000, 1.25));
            kek.DodajKamion(new Kamion("Scania 4", 1000, 1.125));
            kek.DodajKamion(new Kamion("Scania 5", 2000, 2));
            Console.WriteLine("Stanje {0} je {1}", kek.Naziv, kek.Budzet);

            Console.WriteLine("Najjeftinija roba : ");
            Console.WriteLine(kek.PronadjiNajjeftinijuRobu());

            Console.WriteLine(kek);
            kek.Sortiraj();
            Console.WriteLine(kek);

            Console.ReadKey(true);
        }
    }
}
