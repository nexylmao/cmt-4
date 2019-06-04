using System.ServiceModel;
using PozoristeCommon;
using System;

namespace PozoristeServer
{
    class Program
    {
        const string address = "net.tcp://localhost:8000";

        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(Servis));
            serviceHost.AddServiceEndpoint(typeof(IServis), new NetTcpBinding(), address);
            serviceHost.Open();
            Console.WriteLine("Server up on port 8000.");
            while (Console.ReadKey(true).KeyChar != 'x') { }
            serviceHost.Close();
        }
    }
}
