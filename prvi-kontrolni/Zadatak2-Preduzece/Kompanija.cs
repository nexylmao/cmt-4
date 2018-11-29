using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2_Preduzece
{
    public class Kompanija
    {
        private List<Kamion> kamioni;
        private string naziv;
        private double budzet;

        public Kompanija()
        {
            naziv = "Para i Jaje";
            budzet = 1000;
            kamioni = new List<Kamion>();
        }

        public Kompanija(string naziv, double budzet)
        {
            this.naziv = naziv;
            this.budzet = budzet;
            kamioni = new List<Kamion>();
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }
        }

        public double Budzet
        {
            get
            {
                return budzet;
            }
        }

        // dobro je, ovde je prvo veliko c:
        public bool DodajKamion(Kamion k)
        {
            if (Budzet - (k.Cena * k.KolicinaTereta) >= 0)
            {
                try
                {
                    kamioni.Add(k);
                    budzet -= (k.Cena * k.KolicinaTereta);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Kamion PronadjiNajjeftinijuRobu()
        {
            double min = double.MaxValue;
            int index = -1;
            for (int i = 0; i < kamioni.Count; i++)
            {
                if (kamioni[i].Cena < min)
                {
                    index = i;
                    min = kamioni[i].Cena;
                }
            }
            if (index == -1)
            {
                return null;
            }
            return kamioni[index];
        }

        public void Sortiraj()
        {
            kamioni.Sort(new Kamion.KamionComparer());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Kompanija : " + naziv);
            foreach (Kamion x in kamioni)
            {
                sb.Append(x);
            }
            return sb.ToString();
        }
    }
}
