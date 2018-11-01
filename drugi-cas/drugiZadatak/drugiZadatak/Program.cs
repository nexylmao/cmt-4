using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    class KompleksanBroj
    {
        private int realanDeo, imaginarniDeo;

        public KompleksanBroj(int realanDeo, int imaginarniDeo)
        {
            this.realanDeo = realanDeo;
            this.imaginarniDeo = imaginarniDeo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KompleksanBroj broj = new KompleksanBroj(3, 4);
        }
    }
}
