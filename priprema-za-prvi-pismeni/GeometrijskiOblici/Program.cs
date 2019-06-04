using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    class Program
    {
        static void Main(string[] args)
        {
            Trougao t = new Trougao(3);
            Pravougaonik p = new Pravougaonik(4, 5);
            Sestougao s = new Sestougao(7);

            Console.WriteLine(t);
            Console.WriteLine("Obim : " + t.IzracunajObim());
            Console.WriteLine("Povrsina : " + t.IzracunajPovrsinu());

            Console.ReadKey(true);
        }
    }
}
