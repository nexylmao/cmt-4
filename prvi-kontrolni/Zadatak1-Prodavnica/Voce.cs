using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1_Prodavnica
{
    public sealed class Voce : Artikal
    {
        private string zemljaPorekla;

        public Voce() : base() { }

        public Voce(string idArtikla, string naziv, double cena, string zemljaPorekla) : base(idArtikla, naziv, cena)
        {
            this.zemljaPorekla = zemljaPorekla;
        }

        public string ZemljaPorekla
        {
            get
            {
                return zemljaPorekla;
            }

            set
            {
                zemljaPorekla = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Voce {");
            sb.AppendLine("\tID : " + idArtikla);
            sb.AppendLine("\tNaziv : " + naziv);
            sb.AppendLine("\tCena : " + cena);
            sb.AppendLine("\tZemlja Porekla : " + zemljaPorekla);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
