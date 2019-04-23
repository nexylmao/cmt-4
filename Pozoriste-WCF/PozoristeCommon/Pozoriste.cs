using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PozoristeCommon
{
    [DataContract]
    public class Pozoriste
    {
        #region Fields
        private string id;
        private string ime;
        private string grad;
        private List<string> predstave;
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
        public string Grad
        {
            get
            {
                return grad;
            }

            set
            {
                grad = value;
            }
        }
        [DataMember]
        public List<string> Predstave
        {
            get
            {
                return predstave;
            }

            set
            {
                predstave = value;
            }
        }
        #endregion
        #region Constructors
        public Pozoriste()
        {
            id = Guid.NewGuid().ToString();
        }
        public Pozoriste(string ime, string grad, List<string> predstave = null)
        {
            id = Guid.NewGuid().ToString();
            this.grad = grad;
            this.ime = ime;
            if (predstave == null)
            {
                this.predstave = new List<string>();
            }
            else
            {
                this.predstave = predstave;
            }
        }
        #endregion
    }
}
