using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PozoristeCommon;
using System.ServiceModel;

namespace PozoristeClient
{
    class Program
    {
        const string hostAddress = "net.tcp://localhost:8000";

        static void Main(string[] args)
        {
            var channelFactory = new ChannelFactory<IServis>(new NetTcpBinding(), new EndpointAddress(hostAddress));
            var proxy = channelFactory.CreateChannel();

            var predstava1 = new Predstava("Predstava 1", 2019, 120);
            var predstava2 = new Predstava("Predstava 2", 2019, 150);
            proxy.DodajPredstavu(predstava1);
            proxy.DodajPredstavu(predstava2);

            var pozoriste1 = new Pozoriste("Pozoriste 1", "Grad 1");
            var pozoriste2 = new Pozoriste("Pozoriste 2", "Grad 2");
            proxy.DodajPozoriste(pozoriste1);
            proxy.DodajPozoriste(pozoriste2);

            proxy.DodajPredstavuNaRepertor(pozoriste1.Id, predstava1.Id);
            proxy.DodajPredstavuNaRepertor(pozoriste1.Id, predstava2.Id);
            proxy.DodajPredstavuNaRepertor(pozoriste2.Id, predstava1.Id);

            Console.WriteLine("Pre brisanja!");
            Console.WriteLine(JsonConvert.SerializeObject(proxy.GetPredstave(), Formatting.Indented));
            Console.WriteLine(JsonConvert.SerializeObject(proxy.GetPozorista(), Formatting.Indented));

            try
            {
                proxy.ObrisiPredstavu(predstava2.Id);
            }
            catch (FaultException<Zmaj> exception)
            {
                Console.WriteLine("Ovde program treba da pukne!");
                Console.WriteLine(exception.Detail.GetCatchPhrase());
            }

            proxy.ObrisiPozoriste(pozoriste1.Id);
            proxy.ObrisiPredstavu(predstava2.Id);

            Console.WriteLine("Posle brisanja!");
            Console.WriteLine(JsonConvert.SerializeObject(proxy.GetPredstave(), Formatting.Indented));
            Console.WriteLine(JsonConvert.SerializeObject(proxy.GetPozorista(), Formatting.Indented));

            Console.ReadKey(true);
        }
    }
}
