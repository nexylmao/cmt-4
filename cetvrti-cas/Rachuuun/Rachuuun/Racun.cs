using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachuuun
{
    public class Racun
    {
        string brojRacuna;
        string imeKorisnika;
        double sredstva;
        double dozvoljeniMinus;

        public string BrojRacuna { get => brojRacuna; }
        public string ImeKorisnika { get => imeKorisnika; }
        public double Sredstva { get => sredstva; }
        public double DozvoljeniMinus { get => dozvoljeniMinus; }

        public Racun(string brojRacuna, string imeKorisnika, double sredstva, double dozvoljeniMinus)
        {
            this.brojRacuna = brojRacuna;
            this.imeKorisnika = imeKorisnika;
            this.sredstva = sredstva;
            this.dozvoljeniMinus = dozvoljeniMinus;
        }

        public bool DodajBalans(double balans)
        {
            try
            {
                sredstva += balans;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PodigniNovac(double novac)
        {
            try
            {
                if (sredstva - novac < dozvoljeniMinus)
                {
                    return false;
                }
                else
                {
                    sredstva -= novac;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
