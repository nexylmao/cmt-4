using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ojblici
{
    class Program
    {
        private static List<string> dozvoljeniOblici = new List<string>{"trougao", "kvadrat", "sestougao"};

        static void Main(string[] args)
        {
            string oblik = args[0];
            if (dozvoljeniOblici.IndexOf(oblik) == -1)
            {
                Console.WriteLine("Unet je nepoznat oblik.");
                Console.ReadKey(true);
                return;
            }

            int stranica = 0, obim = 0;
            double povrsina = 0;
            try
            {
                Console.Write("Duzina stranice > ");
                stranica = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uradi nesto kaj ne valja.");
            }

            switch (dozvoljeniOblici.IndexOf(oblik))
            {
                case 0:
                    obim = 3 * stranica;
                    povrsina = (Math.Pow(stranica, 2) * Math.Sqrt(3)) / 4;
                    break;
                case 1:
                    obim = 4 * stranica;
                    povrsina = Math.Pow(stranica, 2);
                    break;
                case 2:
                    obim = 6 * stranica;
                    povrsina = 6 * (Math.Pow(stranica, 2) * Math.Sqrt(3)) / 4;
                    break;
            }

            Console.WriteLine("Obim - " + obim);
            Console.WriteLine("Povrsina - " + povrsina);
            Console.ReadKey(true);
        }
    }
}
