using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1_Prodavnica
{
    public sealed class Sok : Artikal
    {
        private string proizvodjac;
        private bool gazirani;

        public Sok() : base() { }

        public Sok(string idArtikla, string naziv, double cena, string proizvodjac, bool gazirani) : base(idArtikla, naziv, cena)
        {
            this.proizvodjac = proizvodjac;
            this.gazirani = gazirani;
        }

        public string Proizvodjac
        {
            get
            {
                return proizvodjac;
            }

            set
            {
                proizvodjac = value;
            }
        }

        public bool Gazirani
        {
            get
            {
                return gazirani;
            }

            set
            {
                gazirani = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sok {");
            sb.AppendLine("\tID : " + idArtikla);
            sb.AppendLine("\tNaziv : " + naziv);
            sb.AppendLine("\tCena : " + cena);
            sb.AppendLine("\tProizvodjac : " + proizvodjac);
            if (gazirani)
            {
                sb.AppendLine("\tGazirano pice.");
            }
            else
            {
                sb.AppendLine("\tNegazirano pice.");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
