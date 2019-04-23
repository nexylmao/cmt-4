using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PozoristeCommon;

namespace PozoristeServer
{
    public class Servis : IServis
    {
        private Dictionary<string, Predstava> dbPredstave;
        private Dictionary<string, Pozoriste> dbPozorista;

        public Servis()
        {
            dbPredstave = new Dictionary<string, Predstava>();
            dbPozorista = new Dictionary<string, Pozoriste>();
        }

        public bool DodajPozoriste(Pozoriste pozoriste)
        {
            if (dbPozorista.ContainsKey(pozoriste.Id))
            {
                throw new FaultException<Zmaj>(new Zmaj("Pa vec imam takvo pozoriste jooooj"));
            }
            dbPozorista.Add(pozoriste.Id, pozoriste);
            return true;
        }

        public bool DodajPredstavu(Predstava predstava)
        {
            if (dbPredstave.ContainsKey(predstava.Id))
            {
                throw new FaultException<Zmaj>(new Zmaj("Pa vec imam takvu predstavu jooooj"));
            }
            dbPredstave.Add(predstava.Id, predstava);
            return true;
        }

        public void DodajPredstavuNaRepertor(string idPozorista, string idPredstave)
        {
            if (!dbPredstave.ContainsKey(idPredstave))
            {
                throw new FaultException<Zmaj>(new Zmaj("Pa nema tog predstavnika, ne svratise taj u selo!"));
            }
            if (!dbPozorista.ContainsKey(idPozorista))
            {
                throw new FaultException<Zmaj>(new Zmaj("Pa nema tog prozora, joooj..."));
            }
            if (dbPozorista[idPozorista].Predstave.IndexOf(idPredstave) != -1)
            {
                throw new FaultException<Zmaj>(new Zmaj("ajo, pa to pozoriste vec prikazuje to"));
            }
            dbPozorista[idPozorista].Predstave.Add(idPredstave);
        }

        public void ObrisiPozoriste(string idPozorista)
        {
            if (!dbPozorista.ContainsKey(idPozorista))
            {
                throw new FaultException<Zmaj>(new Zmaj("Pa vec ba nema tog pozorista! OJ SVETE!"));
            }
            dbPozorista.Remove(idPozorista);
        }

        public void ObrisiPredstavu(string idPredstave)
        {
            if (!dbPredstave.ContainsKey(idPredstave))
            {
                throw new FaultException<Zmaj>(new Zmaj("Pa vec ba nema te predstave! OJ SVETE!"));
            }
            foreach (Pozoriste p in dbPozorista.Values)
            {
                if (p.Predstave.IndexOf(idPredstave) != -1)
                {
                    throw new FaultException<Zmaj>(new Zmaj("Pa nemere tako lako, to se prikazuje u " + p.Ime));
                }
            }
            dbPredstave.Remove(idPredstave);
        }

        public IEnumerable<Pozoriste> GetPozorista()
        {
            return dbPozorista.Values.ToList();
        }

        public IEnumerable<Predstava> GetPredstave()
        {
            return dbPredstave.Values.ToList();
        }
    }
}
