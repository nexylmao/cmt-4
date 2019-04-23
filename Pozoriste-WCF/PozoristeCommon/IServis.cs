using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace PozoristeCommon
{
    [ServiceContract]
    public interface IServis
    {
        [OperationContract]
        [FaultContract(typeof(Zmaj))]
        bool DodajPredstavu(Predstava predstava);

        [OperationContract]
        [FaultContract(typeof(Zmaj))]
        void ObrisiPredstavu(string idPredstave);

        [OperationContract]
        [FaultContract(typeof(Zmaj))]
        bool DodajPozoriste(Pozoriste pozoriste);

        [OperationContract]
        [FaultContract(typeof(Zmaj))]
        void ObrisiPozoriste(string idPozorista);

        [OperationContract]
        [FaultContract(typeof(Zmaj))]
        void DodajPredstavuNaRepertor(string idPozorista, string idPredstave);

        [OperationContract]
        IEnumerable<Pozoriste> GetPozorista();

        [OperationContract]
        IEnumerable<Predstava> GetPredstave();
    }
}
