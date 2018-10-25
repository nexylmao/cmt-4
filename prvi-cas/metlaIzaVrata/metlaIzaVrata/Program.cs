using System;
using System.Runtime.InteropServices;

namespace metlaIzaVrata
{
    class Program
    {
        private static int[] danMesec = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        public static Osoba consoleCreate()
        {
            Osoba o = new Osoba(); // ako ne uspemo, prosto je ne vratimo, GarbageCollector sam ocisti jer nema reference kek
            Console.WriteLine("\tOJ UNESI OSOBU M8 :");
            try
            {
                Console.Write("Oj daj tvoje zlatno ime > ");
                o.Ime = Console.ReadLine();
                Console.Write("Oj ciji si ti? > ");
                o.Prezime = Console.ReadLine();
                Console.Write("Oj daj mi emajl > ");
                o.Email = Console.ReadLine();
                int dan, mesec, godna;
                do
                {
                    Console.Write("Oj daj prvo onaj drugi broj u datumu rodjenja (1-12) > ");
                    mesec = Convert.ToInt32(Console.ReadLine());
                    if (mesec < 1 || mesec > 12)
                    {
                        Console.WriteLine("Sad ces da castis jer zajebavas (oj).");
                    }
                } while (mesec < 1 || mesec > 12);

                int mozeDan = danMesec[mesec - 1];
                do
                {
                    Console.Write("Oj ajde sad dan kad znam koji je mesec (1 - " + mozeDan + ")(oj) > ");
                    dan = Convert.ToInt32(Console.ReadLine());
                    if (dan < 1 || dan > mozeDan)
                    {
                        Console.WriteLine("Jepse (oj).");
                    }
                } while (dan < 1 || dan > mozeDan);

                do
                {
                    Console.Write("E ae sad koje godine si se ulogovao na www.world.com (1910 - " + DateTime.Today.Year + ")(oj) > ");
                    godna = Convert.ToInt32(Console.ReadLine());
                    if (godna < 1910 || godna > DateTime.Today.Year)
                    {
                        Console.WriteLine("A daj stvarno vise. Sad cu da izadjem, sad me nerviras.");
                        return null;
                    }
                } while (godna < 1910 || godna > DateTime.Today.Year);
                o.DatumRodjenja = new DateTime(godna, mesec, dan);
                return o;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oj sta uradi m8?");
                return null;
            }
        }
        
        static void Main(string[] args)
        {
            Osoba uneta = consoleCreate();
            TimeSpan razlika = DateTime.Now.Subtract(uneta.DatumRodjenja);
            int brojGodina = razlika.Days / 365;
            
            Console.WriteLine("Ime ti oj - " + uneta.Ime);
            Console.WriteLine("Prez'me ti je oj m8 - " + uneta.Prezime);
            if (brojGodina > 15)
            {
                Console.WriteLine("Ti zavrsi osnovu, pre " + (brojGodina - 15) + " god'na. Oj.");
            }
            else
            {
                Console.WriteLine("Aha, ides jos u ojsnovnu. Hahaha. Nube.");
            }

            Console.WriteLine("OJ.");
            Console.ReadKey(true);
        }
    }
}
