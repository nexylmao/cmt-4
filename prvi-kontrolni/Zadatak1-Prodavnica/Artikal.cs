using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1_Prodavnica
{
    public class Artikal
    {
        protected string idArtikla;
        protected string naziv;
        protected double cena;

        public Artikal() {}

        public Artikal(string idArtikla, string naziv, double cena)
        {
            this.idArtikla = idArtikla;
            this.naziv = naziv;
            this.cena = cena;
        }

        public string IdArtikla
        {
            get
            {
                return idArtikla;
            }

            set
            {
                idArtikla = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                cena = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Artikal {");
            sb.AppendLine("\tID : " + idArtikla);
            sb.AppendLine("\tNaziv : " + naziv);
            sb.AppendLine("\tCena : " + cena);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
