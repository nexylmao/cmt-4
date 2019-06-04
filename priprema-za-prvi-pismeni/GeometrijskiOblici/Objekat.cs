using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    public abstract class Objekat
    {
        protected static uint instances;
        public static uint Instances { get => instances; }
        public abstract double IzracunajObim();
        public abstract double IzracunajPovrsinu();
    }

    public class Pravougaonik : Objekat
    {
        private double a;
        private double b;
        public double A { get => a; }
        public double B { get => b; }

        public Pravougaonik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double IzracunajObim()
        {
            return 2 * (a + b);
        }

        public override double IzracunajPovrsinu()
        {
            return a * b;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pravougaonik {");
            sb.AppendLine("\tA: " + a);
            sb.AppendLine("\tB: " + b);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class Trougao : Objekat
    {
        private double a;
        public double A { get => a; }

        public Trougao(double a)
        {
            this.a = a;
        }

        public override double IzracunajObim()
        {
            return 3 * a;
        }

        public override double IzracunajPovrsinu()
        {
            return Math.Pow(a, 2) * Math.Sqrt(3) / 4;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Trougao {");
            sb.AppendLine("\tA: " + a);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class Sestougao : Objekat
    {
        private double a;
        public double A { get => a; }

        public Sestougao(double a)
        {
            this.a = a;
        }

        public override double IzracunajObim()
        {
            return 6 * a;
        }

        public override double IzracunajPovrsinu()
        {
            return 6 * ((Math.Pow(a, 2) * Math.Sqrt(3)) / 4);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sestougao {");
            sb.AppendLine("\tA: " + a);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
