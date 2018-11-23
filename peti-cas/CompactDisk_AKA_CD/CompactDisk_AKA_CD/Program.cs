using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactDisk_AKA_CD
{
    class Program
    {
        static void Main(string[] args)
        {
            CompactDisk cd2, cd3;
            cd2 = new CompactDisk("The Strange Case Of", "Halestorm", new DateTime(2012, 4, 10));
            cd2.DodajPesmu("Mz. Hyde");
            cd2.DodajPesmu("Love Bites (But So Do I)");
            cd2.DodajPesmu("I Miss The Misery");
            Console.WriteLine(cd2);

            cd3 = new CompactDisk("Into The Wild Life", "Halestorm", new DateTime(2015, 4, 10));
            cd3.DodajPesmu("Scream");
            cd3.DodajPesmu("I Like It Heavy");
            cd3.DodajPesmu("I Am The Fire");
            Console.WriteLine(cd3);
            Console.ReadKey(true);
        }
    }
}
