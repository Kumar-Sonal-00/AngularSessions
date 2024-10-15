using System.Collections;

namespace HashtableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("username", "administrator");
            ht.Add("password", "admin123");
            ht.Add("server", "localhost");

            Console.WriteLine("Username:" + ht["username"]);
            Console.WriteLine("Password:" + ht["password"]);
            Console.WriteLine("Server:" + ht["server"]);

            Console.WriteLine("\nTraverse using keys collection");
            foreach (string k in ht.Keys)
            {
                Console.WriteLine($"{k}:{ht[k]}");
            }

            Console.WriteLine("\nTraverse using values collection");
            foreach (string v in ht.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\nTraverse using IEnumerator interface of keys");
            IEnumerator ien_k=ht.Keys.GetEnumerator();
            while(ien_k.MoveNext())
            {
                string key=ien_k.Current.ToString();
                string value = ht[key].ToString();
                Console.WriteLine(key+":"+value);
            }

            Console.WriteLine("\nTraverse using IEnumerator interface of values");
            IEnumerator ien_v = ht.Values.GetEnumerator();
            while (ien_v.MoveNext())
            {
                
                string value = ien_v.Current.ToString();
                Console.WriteLine(value);
            }
        }
    }
}


