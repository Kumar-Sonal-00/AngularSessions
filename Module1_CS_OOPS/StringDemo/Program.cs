using System.Text;

namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            Console.WriteLine(s1);
            s1 = s1 + " World";
            Console.WriteLine(s1);

            //StringBuilder s2 = new StringBuilder("");
            //for(int i=1;i<100000;i++)
            //{
            //    s2.AppendLine("i=" + i);
            //}
            //Console.WriteLine(s2.ToString());


            string s3 = "Welcome to INDIA";
            //for (int i = 0; i < s3.Length; i++)
            //{
            //    Console.WriteLine(s3[i]);
            //}

            foreach (char c in s3)
            {
                Console.WriteLine(c);
            }

            string s4 = "This is my sample sentence,it shows string demos";

            string[] words = s4.Split(' ',',');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string finalStr=String.Join("#", words);
            Console.WriteLine(finalStr);

            string s5 = String.Concat("This", " is", " concatenated", " string");
            Console.WriteLine(s5);
        }
    }
}
