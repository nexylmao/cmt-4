using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1_Prodavnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Prodavnica proda, vnica;
            proda = new Prodavnica("Proda");
            vnica = new Prodavnica("Vnica");

            // mi ne pijemo ne gazirane sokove
            Sok ultra, booster, redBull, monster, hell, rockstar;
            ultra = new Sok("ULTRA", "Ultra Energy 0.5", 74, "Coca-Cola", true);
            booster = new Sok("BOOSTER", "Booster Energy 0.5", 59, "Nectar", true);
            redBull = new Sok("REDBULL", "RedBull daje mi krila", 149, "RedBull", true);
            monster = new Sok("MONSTER", "Monster Ripper Juiced", 119, "Monster", true);
            hell = new Sok("HELL", "HELL Multivitamin 0.25", 49, "HELL", true);
            rockstar = new Sok("ROCKSTAR", "Rockstar 0.33", 59, "Rockstar", true);

            Voce mandarina, narandza, jabuka, grozdje, sljiva, kajsija;
            mandarina = new Voce("MANDARIN", "Mandarina ona bez kostica", 100, "Stvarno ne znam");
            narandza = new Voce("NARANDZA", "Narandza", 120, "Isto odakle i mandarine, pretpostavljam");
            jabuka = new Voce("JABUKA", "Jabuka", 59, "Srbija");
            grozdje = new Voce("GROZDJE", "Grozdje", 89, "Srbija");
            sljiva = new Voce("SLJIVA", "Sljiva", 69, "Srbija");
            kajsija = new Voce("KAJSIJA", "Kajsija", 79, "Srbija");

            proda.DodajArtikal(ultra);
            proda.DodajArtikal(monster);
            proda.DodajArtikal(rockstar);
            proda.DodajArtikal(mandarina);
            proda.DodajArtikal(narandza);
            proda.DodajArtikal(kajsija);
            proda.DodajArtikal(sljiva);

            vnica.DodajArtikal(booster);
            vnica.DodajArtikal(redBull);
            vnica.DodajArtikal(hell);
            vnica.DodajArtikal(ultra);
            vnica.DodajArtikal(jabuka);
            vnica.DodajArtikal(mandarina);
            vnica.DodajArtikal(grozdje);

            Console.WriteLine(proda);
            Console.WriteLine(vnica);

            Console.WriteLine("Proda ima {0} voca", proda.BrojVoca());
            Console.WriteLine("Vnica ima {0} voca", vnica.BrojVoca());

            proda.ObrisiArtikal("ROCKSTAR");
            vnica.ObrisiArtikal("JABUKA");

            Console.WriteLine("Vrednost svega u prodi je {0}", proda.UkupnaVrednost());
            Console.WriteLine("Vrednost svega u vnici je {0}", vnica.UkupnaVrednost());

            Console.ReadKey();
        }
    }
}
