namespace const_readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Demo
    {
        const int x = 10;
        readonly int y;

        public Demo()
        {
            //x = 30; //invalid
            y = 20;
        }
        public void SetValue()
        {
            //y = 20; //invalid
        }
    }
}
