using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace MySerializer
{
    class Program
    {
        static void Serialize<T>(T obj, string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            TextWriter tw = new StreamWriter(fileName);
            xs.Serialize(tw, obj);
            tw.Close();
        }

        static T Deserialize<T>(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            TextReader tr = new StreamReader(fileName);
            return (T)xs.Deserialize(tr);
        }

        static void Main(string[] args)
        {
            Student st = new Student("Nenad", "Vuletic", "DONTYOUF", new DateTime(2000, 8, 19));
            Serialize(st, "Nenad.xml");
            Student st2 = Deserialize<Student>("Nenad.xml");
            Console.WriteLine(st2);
            Console.ReadKey(true);
        }
    }
}
