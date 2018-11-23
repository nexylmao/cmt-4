using System;
using System.Reflection;
using System.Text;

namespace Nexy
{
    public class ToBeReflected
    {
        public int x, y;
    }

    public static class JsonParser
    {
        public static string ParseToJsonDepthOne(object obj)
        {
            StringBuilder x = new StringBuilder();

            x.AppendLine("{");
            Type type = obj.GetType();
            for(int i = 0; i < type.GetFields().Length; i++)
            {
                FieldInfo field = type.GetFields()[i];
                x.Append("\t\"" + field.Name + "\": " + field.GetValue(obj));
                if (i + 1 != type.GetFields().Length)
                {
                    x.AppendLine(",");
                }
                else
                {
                    x.AppendLine();
                }
            }
            x.AppendLine("}");

            return x.ToString();
        }
    }
}

namespace nekaReflekcija
{
    class Program
    {
        static void Main(string[] args)
        {
            Nexy.ToBeReflected x = new Nexy.ToBeReflected()
            {
                x = 3,
                y = 2
            };

            Console.WriteLine(Nexy.JsonParser.ParseToJsonDepthOne(x));

            Console.ReadKey(true);
        }
    }
}
