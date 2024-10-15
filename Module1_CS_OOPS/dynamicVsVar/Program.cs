namespace dynamicVsVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic d;
            d = 100;
            Console.WriteLine(d.GetType());
            d = "Hello";
            Console.WriteLine(d.ToUpper()); //no intelligence

            
            
            var x = 100;
            Console.WriteLine(x.GetType()); //gives intelligence
        }
    }
}
