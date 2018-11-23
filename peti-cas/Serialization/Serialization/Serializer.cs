using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public static class Serializer
    {
        public static void Serialize<T>(string filepath, T obj)
        {
            TextWriter tw = new StreamWriter(filepath);
            XmlSerializer xs = new XmlSerializer(typeof(T));
            xs.Serialize(tw, obj);
            tw.Close();
        }

        public static T Deserialize<T>(string filepath)
        {
            TextReader tr = new StreamReader(filepath);
            XmlSerializer xs = new XmlSerializer(typeof(T));
            T obj = (T)xs.Deserialize(tr);
            tr.Close();
            return obj;
        }
    }
}
