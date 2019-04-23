using System.Runtime.Serialization;

namespace PozoristeCommon
{
    [DataContract]
    public class Zmaj
    {
        #region Fields
        private string catchPhrase;
        #endregion
        #region Properties
        [DataMember]
        public string CatchPhrase
        {
            get
            {
                return catchPhrase;
            }

            set
            {
                catchPhrase = value;
            }
        }
        #endregion
        #region Constructors
        public Zmaj(string catchPhrase)
        {
            this.catchPhrase = catchPhrase;
        }
        #endregion
        #region Methods
        public string GetCatchPhrase()
        {
            return string.Format("Dodjose zmaj i zborise : {0}! I bljune vatru, i puf. Ode ti program c:", catchPhrase);
        }
        #endregion
    }
}
