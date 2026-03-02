using System.Xml.Serialization;

namespace Serialisation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { id = 2, name = "Alice" };

            XmlSerializer xs = new XmlSerializer(typeof(Student));2255
            using (TextWriter tw = new StreamWriter("student.xml"))
            {
                xs.Serialize(tw, s);
            }

            using (TextReader tr = new StreamReader("student.xml"))
            {
                Student deserialized = (Student)xs.Deserialize(tr);
                Console.WriteLine($"Id: {deserialized.id}, Name: {deserialized.name}");
            }
        }
    }
}
