using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sluyba
{
    public enum Pol { Muski, Zenski, Ostalo };

    public enum Smer { Smer1, Smer2, Smer3, RN };

    public class Student
    {
        int mBrojIndeksa, mGodina;
        string mIme, mPrezime, mImeRoditelja;
        DateTime mDatumRodjenja;
        Pol mPol;
        Smer mSmer;

        public int BrojIndeksa
        {
            get
            {
                return mBrojIndeksa;
            }

            set
            {
                mBrojIndeksa = value;
            }
        }
        public int Godina
        {
            get
            {
                return mGodina;
            }
            set
            {
                mGodina = value;
            }
        }
        public string Ime
        {
            get
            {
                return mIme;
            }
            set
            {
                mIme = value;
            }
        }
        public string Prezime
        {
            get
            {
                return mPrezime;
            }
            set
            {
                mPrezime = value;
            }
        }
        public string ImeRoditelja
        {
            get
            {
                return mImeRoditelja;
            }
            set
            {
                mImeRoditelja = value;
            }
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return mDatumRodjenja;
            }
            set
            {
                mDatumRodjenja = value;
            }
        }
        public Pol Pol
        {
            get
            {
                return mPol;
            }
            set
            {
                mPol = value;
            }
        }
        public Smer Smer
        {
            get
            {
                return mSmer;
            }
            set
            {
                mSmer = value;
            }
        }

        public Student() { }

        public Student(int brojIndeksa, string ime, string prezime, string imeRoditelja, int godina, DateTime datumRodjenja, Pol pol, Smer smer)
        {
            this.mBrojIndeksa = brojIndeksa;
            this.mIme = ime;
            this.mPrezime = prezime;
            this.mImeRoditelja = imeRoditelja;
            this.mGodina = godina;
            this.mDatumRodjenja = datumRodjenja;
            this.mPol = pol;
            this.mSmer = smer;
        }
    }
}
