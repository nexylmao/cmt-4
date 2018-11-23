using System;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u = new Ucenik("Ucenik1", new DateTime(2000, 8, 19), "Gimnazija JJZ", 4);

            Serializer.Serialize("nexyy.txt", u);
            Console.WriteLine(Serializer.Deserialize<Ucenik>("nexyy.txt"));

            Console.ReadKey(true);
        }
    }
}
