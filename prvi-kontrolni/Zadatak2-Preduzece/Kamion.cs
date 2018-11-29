using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2_Preduzece
{
    public class Kamion
    {
        public class KamionComparer : IComparer<Kamion>
        {
            public int Compare(Kamion x, Kamion y)
            {
                if ((x.Cena * x.KolicinaTereta) > (y.Cena * y.KolicinaTereta))
                {
                    return 1;
                }
                else if ((x.Cena * x.KolicinaTereta) < (y.Cena * y.KolicinaTereta))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private int kolicinaTereta;
        private double cena;
        private string naziv;

        public Kamion() { }

        public Kamion(string naziv, int kolicinaTereta, double cena)
        {
            this.naziv = naziv;
            this.kolicinaTereta = kolicinaTereta;
            this.cena = cena;
        }

        public int KolicinaTereta
        {
            get
            {
                return kolicinaTereta;
            }

            set
            {
                kolicinaTereta = value;
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

        public override string ToString()
        {
            return string.Format("Kamion {0} nosi {1} kg tereta, cija je cena {2} evra po kg.\n", naziv, kolicinaTereta, cena);
        }
    }
}
