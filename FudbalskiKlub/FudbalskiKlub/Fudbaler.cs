using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FudbalskiKlub
{
    public enum Pozicija { GOLMAN, ODBRANA, SREDINA, NAPAD };

    public class Fudbaler
    {
        int brojDresa;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        Pozicija pozicija;

        public Fudbaler() { }

        public Fudbaler(int brojDresa, string ime, string prezime, DateTime datumRodjenja, Pozicija pozicija)
        {
            this.brojDresa = brojDresa;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.pozicija = pozicija;
        }

        public int BrojDresa
        {
            get
            {
                return brojDresa;
            }

            set
            {
                brojDresa = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public Pozicija Pozicija
        {
            get
            {
                return pozicija;
            }

            set
            {
                pozicija = value;
            }
        }
    }
}
