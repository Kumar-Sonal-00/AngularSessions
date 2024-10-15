namespace OverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 100, n2 = 200;
            Calculator calc = new Calculator();
            Console.WriteLine($"Sum of {n1} and {n2} is {calc.Add(n1, n2)}");

            int n3 = 300;
            Console.WriteLine($"Sum of {n1},{n2} and {n3} is {calc.Add(n1, n2, n3)}");

            string s1 = "Hello", s2 = "World";
            Console.WriteLine("final string:" + calc.Add(s1, s2));
        }
    }

    class Calculator
    {
        public int Add(int n1,int n2)
        {
            return n1 + n2;
        }
        public int Add(int n1, int n2,int n3)
        {
            return n1 + n2 + n3;
        }
        public string Add(string s1,string s2)
        {
            return s1 + " " + s2;
        }
    }
}
