using System;
using System.Text;
using Newtonsoft.Json;

namespace MySerializer
{
    public class Student
    {
        string name;
        string familyName;
        string jmbg;
        DateTime birthday;

        public Student() { }

        public Student(string name, string familyName, string jmbg, DateTime birthday)
        {
            this.name = name;
            this.familyName = familyName;
            this.jmbg = jmbg;
            this.birthday = birthday;
        }

        public string Name { get => name; set => name = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string JMBG { get => jmbg; set => jmbg = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
