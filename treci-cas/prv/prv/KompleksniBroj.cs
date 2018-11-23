using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prv
{
    class KompleksniBroj
    {
        private int real;
        private int imag;

        private static int instances = 0;

        public int Real { get => real; }
        public int Imag { get => imag; }
        public static int Instances { get => instances; }

        public KompleksniBroj()
        {
            instances++;
            this.real = 0;
            this.imag = 0;
        }

        public KompleksniBroj(int real, int imag)
        {
            instances++;
            this.real = real;
            this.imag = imag;
        }

    }
}
