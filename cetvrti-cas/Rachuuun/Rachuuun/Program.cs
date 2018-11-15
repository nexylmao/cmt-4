using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachuuun
{
    class Program
    {
        static void Main(string[] args)
        {
            Racun racun = new Racun("SubscribeToPewdiepie", "Kek", 1000, -1000);
            char input = (char)0;

            do
            {
                Console.WriteLine("_________RACUN________");
                Console.WriteLine("Q - Ispisi balans");
                Console.WriteLine("W - Dodaj na balans");
                Console.WriteLine("E - Skini sa balansa");
                Console.WriteLine("X - Izadji iz programa");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (input)
                {
                    case 'Q':
                    case 'q':
                        Console.WriteLine("Balans : " + racun.Sredstva);
                        break;

                    case 'W':
                    case 'w':
                        Console.WriteLine("Unesite koliko da dodamo");
                        Console.Write("> ");
                        try
                        {
                            double balans = Convert.ToDouble(Console.ReadLine());
                            if (racun.DodajBalans(balans))
                            {
                                Console.WriteLine("Uspesno dodat balans.");
                            }
                            else
                            {
                                throw new Exception("Nismo uspeli da dodamo na balans.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 'E':
                    case 'e':
                        Console.WriteLine("Unesite koliko da skinemo");
                        Console.Write("> ");
                        try
                        {
                            double balans = Convert.ToDouble(Console.ReadLine());
                            if (racun.PodigniNovac(balans))
                            {
                                Console.WriteLine("Uspesno skinut balans.");
                            }
                            else
                            {
                                throw new Exception("Nismo uspeli da skinemo sa balansa.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 'X':
                    case 'x':
                        // nista se ne desava, do while ce nas izbaciti napolje
                        break;

                    default:
                        Console.WriteLine("Uneli ste opciju koja ne postoji.");
                        break;
                }
            }
            while (input != 'X' && input != 'x');
        }
    }
}
