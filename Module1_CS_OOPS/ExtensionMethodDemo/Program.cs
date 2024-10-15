namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10; int y = 5;
            Console.WriteLine($"Square of {x}:{x.Square()}");
            Console.WriteLine($"Cube of {x}:{x.Cube()}");

            Console.WriteLine($"{x} divide by {y} is {x.DivideBy(y)}");


            string s = "Hello";
            Console.WriteLine("Length:" + s.NoOfCharacters());

        }
    }

    static class ExtInt
    {
        public static int Square(this int x)
        {
            return x * x;
        }
        public static int Cube(this int x)
        {
            return x * x * x;
        }
        public static int DivideBy(this int x,int y)
        {
            return x / y;
        }

        public static int NoOfCharacters(this string s)
        {
            return s.Length;
        }
    }
}
