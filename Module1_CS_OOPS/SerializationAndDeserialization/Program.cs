using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationAndDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            //SerializeBinary();
            //DeserializeBinary();

            //XmlSerializerDemo();
            //XmlDeserializerDemo();

            //SerializeJson();
            //DeserializeJson();
        }
        static void SerializeBinary()
        {
            //create the object with data
            Product product = new Product
            {
                ProductId = 1001,
                Description = "Mi TV",
                Price = 25000.00,
                Quantity = 20
            };

            //create the file stream
            FileStream fs = new FileStream(@"C:\CGI2024_DotnetCore\product.txt", FileMode.Create, FileAccess.Write);

            //create binary formatter
            BinaryFormatter bf = new BinaryFormatter();

            //serialize the object using binary formatter
            bf.Serialize(fs, product);
            fs.Close();

            Console.WriteLine("Object serialized to file");

        }

        static void DeserializeBinary()
        {
            //create the file stream
            FileStream fs = new FileStream(@"C:\CGI2024_DotnetCore\product.txt", FileMode.Open, FileAccess.Read);

            //create binary formatter
            BinaryFormatter bf = new BinaryFormatter();

            //desrialize the object from filestream using binary formatter
            Product p=(Product)bf.Deserialize(fs);
            fs.Close();

            //display the data
            Console.WriteLine($"{p.ProductId}\t{p.Description}\t{p.ProductId}\t{p.Quantity}");
        }

        static void XmlSerializerDemo()
        {
            //create the object with data
            Product product = new Product
            {
                ProductId = 1001,
                Description = "Mi TV",
                Price = 25000.00,
                Quantity = 20
            };

            //create the file stream
            FileStream fs = new FileStream(@"C:\CGI2024_DotnetCore\product.xml", FileMode.Create, FileAccess.Write);

            //create xml serializer
            XmlSerializer xmlSer = new XmlSerializer(typeof(Product));

            //serialize the data into xml
            xmlSer.Serialize(fs, product);
            fs.Close();

            Console.WriteLine("Object serialized to xml");
        }

        static void XmlDeserializerDemo()
        {           

            //create the file stream
            FileStream fs = new FileStream(@"C:\CGI2024_DotnetCore\product.xml", FileMode.Open, FileAccess.Read);

            //create xml serializer
            XmlSerializer xmlSer = new XmlSerializer(typeof(Product));

            //deserialize the data into xml
            Product p=(Product)xmlSer.Deserialize(fs);
            fs.Close();

            //display the data
            Console.WriteLine($"{p.ProductId}\t{p.Description}\t{p.ProductId}\t{p.Quantity}");
        }

        static void SerializeJson()
        {
            //create the object with data
            Product product = new Product
            {
                ProductId = 1001,
                Description = "Mi TV",
                Price = 25000.00,
                Quantity = 20
            };

            //create the file stream
            FileStream fs = new FileStream(@"C:\CGI2024_DotnetCore\product.json", FileMode.Create, FileAccess.Write);

            //serialize the object using JSON Serializer
            JsonSerializer.Serialize(fs, product);
            fs.Close();

            Console.WriteLine("Object serialized to JSON");

        }

        static void DeserializeJson()
        { 
            //create the file stream
            FileStream fs = new FileStream(@"C:\CGI2024_DotnetCore\product.json", FileMode.Open, FileAccess.Read);

            //deserialize the object using JSON Serializer
            Product p =JsonSerializer.Deserialize<Product>(fs);
            fs.Close();

            //display the data
            Console.WriteLine($"{p.ProductId}\t{p.Description}\t{p.ProductId}\t{p.Quantity}");
        }
    }
}
