using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PozoristeCommon
{
    [DataContract]
    public class Predstava
    {
        #region Fields
        private string id;
        private string ime;
        private int godinaReziranja;
        private int trajanje;
        #endregion
        #region Properties
        [DataMember]
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        [DataMember]
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
        [DataMember]
        public int GodinaReziranja
        {
            get
            {
                return godinaReziranja;
            }

            set
            {
                godinaReziranja = value;
            }
        }
        [DataMember]
        public int Trajanje
        {
            get
            {
                return trajanje;
            }

            set
            {
                trajanje = value;
            }
        }
        #endregion
        #region Constructors
        public Predstava()
        {
            id = Guid.NewGuid().ToString();
        }
        public Predstava(string ime, int godinaReziranja, int trajanje)
        {
            id = Guid.NewGuid().ToString();
            this.ime = ime;
            this.godinaReziranja = godinaReziranja;
            this.trajanje = trajanje;
        }
        #endregion
    }
}
