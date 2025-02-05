using CustomerCommonLib;
using System.Text.Json;
using System.Xml.Serialization;

namespace CustomerDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // XmlSerializer();

           
            var fs = new FileStream("C:\\temp\\cust1.json", FileMode.Open);

            var sr = new StreamReader(fs);
           
            var text = sr.ReadToEnd();
            var customer =JsonSerializer.Deserialize<Customer>(text);

            Console.WriteLine(customer.Name);
            foreach (var address in customer.Addresses)
            {
                Console.WriteLine(address.City);
                Console.WriteLine(address.Country);
            }

        }

        private static void XmlDeSerializer()
        {
            var fs = new FileStream("C:\\temp\\cust1.xml", FileMode.Open);


            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            var reader = new StreamReader(fs);
            var customer1 = (Customer)serializer.Deserialize(reader);

            Console.WriteLine(customer1.Name);
            foreach (var address in customer1.Addresses)
            {
                Console.WriteLine(address.City);
                Console.WriteLine(address.Country);
            }
            reader.Close();
        }
    }
}
