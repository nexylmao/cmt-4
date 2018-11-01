using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi_zadatak
{
    class Inkvizicija
    {
        public static void PlusPlusDva(ref int x)
        {
            x += 2;
        }

        public static void Namjesti(ref int x, ref int y)
        {
            y = x + 2;
        }

        public static void Srednja(IEnumerable<int> values, out int median)
        {
            int sum = 0;
            int count = values.Count();
            foreach(int x in values)
            {
                sum += x;
            }
            median = (int)Math.Round((double)sum / count , 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metod 1");
            int x = 3;
            Console.WriteLine("x : " + x);
            Inkvizicija.PlusPlusDva(ref x);
            Console.WriteLine("x : " + x + '\n');
            x = 5;
            int y = 4;
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            Inkvizicija.Namjesti(ref x, ref y);
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y + '\n');

            int[] niz = { 4, 5, 10, 12 };
            int output;
            Console.WriteLine("niz : ");
            foreach (int i in niz)
            {
                Console.WriteLine(i);
            }

            Inkvizicija.Srednja(niz, out output);
            Console.WriteLine("median : " + output);

            Console.ReadKey();
        }
    }
}
