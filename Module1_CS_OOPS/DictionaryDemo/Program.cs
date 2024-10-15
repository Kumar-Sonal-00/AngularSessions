using System.Collections.Generic;
namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Books:- id(key), name(value)

            Dictionary<int, string> books = new Dictionary<int, string>();

            books.Add(1001, "Learning C# Programming");
            books.Add(1003, "ASP.NET for Beginners");
            books.Add(1002, "MS Sql Server Fundamentals");
            //books.Add(1001, "ASP.NET WEB API"); //duplicate key not allowed
            

            //int id = 1001;
            //Console.WriteLine($"Book id:{id}\nBook name:{books[id]}");


            foreach (int k in books.Keys)
            {
                Console.WriteLine($"Book id:{k}\nBook name:{books[k]}");
                Console.WriteLine("===================================");
            }

            IEnumerator<string> ien_v=books.Values.GetEnumerator();
            while (ien_v.MoveNext())
            {
                Console.WriteLine(ien_v.Current);
            }

            //Traverse using IEnumerator<,> of KeyValuePair

            IEnumerator<KeyValuePair<int, string>> ien_kv = books.GetEnumerator();

            while(ien_kv.MoveNext())
            {
                KeyValuePair<int,string> kv= ien_kv.Current;
                int key= kv.Key;
                string value= kv.Value;
                Console.WriteLine($"Book id:{key}\tBook name:{value}");
            }


            SortedDictionary<int, string> cities = new SortedDictionary<int, string>();
            cities.Add(560054, "Bangalore");
            cities.Add(560023, "Mysore");
            cities.Add(560061, "Mangalore");

            foreach (int pin in cities.Keys)
            {
                Console.WriteLine($"City:{cities[pin]}\tPincode:{pin}");
            }

        }
    }
}
