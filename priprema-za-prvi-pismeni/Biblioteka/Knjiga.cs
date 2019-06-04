using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Knjiga
    {
        string naziv;
        string autor;
        DateTime datumIzdavanja;
        int brojStrana;

        public Knjiga() { }

        public Knjiga(string naziv, string autor, DateTime datumIzdavanja, int brojStrana)
        {
            this.naziv = naziv;
            this.autor = autor;
            this.datumIzdavanja = datumIzdavanja;
            this.brojStrana = brojStrana;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        public int BrojStrana { get => brojStrana; set => brojStrana = value; }
    }
}
