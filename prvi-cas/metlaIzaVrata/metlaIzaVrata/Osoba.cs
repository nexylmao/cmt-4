using System;

namespace metlaIzaVrata
{
    class Osoba
    {
        private string ime, prezime, email;
        private DateTime datumRodjenja;

        public Osoba() {}

        public Osoba(string ime, string prezime, string email, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.datumRodjenja = datumRodjenja;
        }

        public string Ime
        {
            get => ime;
            set => ime = value;
        }

        public string Prezime
        {
            get => prezime;
            set => prezime = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public DateTime DatumRodjenja
        {
            get => datumRodjenja;
            set => datumRodjenja = value;
        }
    }
}
