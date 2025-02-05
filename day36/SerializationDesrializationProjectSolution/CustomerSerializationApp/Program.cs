using CustomerCommonLib;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Windows.Markup;
using System.Xml.Serialization;

namespace CustomerSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // XmlSeriazlier();

            var c1 = new Customer { Id = 1, Name = "Markonda" };
            c1.AddAddress(new Address { City = "Chennai", Country = "India" });

           var stringified= JsonSerializer.Serialize(c1);
            Console.WriteLine(stringified);
            var fs = new FileStream("C:\\temp\\cust1.json", FileMode.Create);

            var sw = new StreamWriter(fs);
            sw.WriteLine(stringified);

            sw.Close();


        }

        private static void XmlSeriazlier()
        {
            var c1 = new Customer { Id = 1, Name = "Markonda" };
            c1.AddAddress(new Address { City = "Chennai", Country = "India" });

            var fs = new FileStream("C:\\temp\\cust1.xml", FileMode.Create);


            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            var writer = new StreamWriter(fs);
            serializer.Serialize(writer, c1);
            writer.Close();
            fs.Close();
        }
    }
}
