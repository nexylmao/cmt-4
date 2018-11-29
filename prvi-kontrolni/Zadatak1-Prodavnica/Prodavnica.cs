using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1_Prodavnica
{
    public class Prodavnica
    {
        private Dictionary<string, Artikal> listaArtikala;
        private string nazivProdavnice;

        public Prodavnica(string nazivProdavnice)
        {
            this.nazivProdavnice = nazivProdavnice;
            listaArtikala = new Dictionary<string, Artikal>();
        }

        // nije java da bude brojVoca xD
        public int BrojVoca()
        {
            int count = 0;
            foreach(Artikal a in listaArtikala.Values)
            {
                if (a.GetType() == typeof(Voce))
                {
                    count++;
                }
            }
            return count;
        }

        // nije java da bude ukupnaVrednost xD
        public double UkupnaVrednost()
        {
            double sum = 0;
            foreach(Artikal a in listaArtikala.Values)
            {
                sum += a.Cena;
            }
            return sum;
        }

        // - || - dodajArtikal xD
        public void DodajArtikal(Artikal a)
        {
            listaArtikala.Add(a.IdArtikla, a);
        }

        // - || - obrisiArtikal xD
        public bool ObrisiArtikal(string id)
        {
            try
            {
                listaArtikala.Remove(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // vidite? ToString, a ne toString!!!!!!!!!
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Prodavnica {0} : ", nazivProdavnice));
            foreach(Artikal a in listaArtikala.Values)
            {
                sb.Append(a);
            }
            sb.AppendLine("___________________________________________");
            return sb.ToString();
        }
    }
}
