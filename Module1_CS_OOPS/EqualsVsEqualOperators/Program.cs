namespace EqualsVsEqualOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2= "hello";

            if (s1 == s2)
            {
                //Console.WriteLine("both the strings are equal");
            }
            else
            {
                //Console.WriteLine("not equal");
            }
            if (s1.Equals(s2))
            {
                //Console.WriteLine("both the strings are equal");
            }
            else
            {
                //Console.WriteLine("not equal");
            }

            Data d1 = new Data { X = 100,Y=200 };
            Data d2 = new Data { X = 100,Y=200 };

            if(d1.Equals(d2))
            {
                Console.WriteLine("Both the objects are same");
            }
            else
            {
                Console.WriteLine("Both objects are not same");
            }

        }
    }

    class Data
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object? obj)
        {
            Data o=(Data)obj;
            if(o.X==this.X && o.Y==this.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
