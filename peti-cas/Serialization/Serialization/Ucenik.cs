using System;
using System.Text;

namespace Serialization
{
    public class Ucenik
    {
        public string ime;
        public DateTime datumRodjenja;
        public string skola;
        public uint razred;

        public Ucenik() { }

        public Ucenik(string ime, DateTime datumRodjenja, string skola, uint razred)
        {
            this.ime = ime;
            this.datumRodjenja = datumRodjenja;
            this.skola = skola;
            this.razred = razred;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Ucenik {");
            builder.AppendLine("\tIme : " + ime);
            builder.AppendLine("\tSkola : " + skola);
            builder.AppendLine("\tRazred : " + razred);
            builder.AppendLine("\tDatum Rodjenja : " + datumRodjenja.ToUniversalTime());
            builder.AppendLine("}");
            return builder.ToString();
        }
    }
}
