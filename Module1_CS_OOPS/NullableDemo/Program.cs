namespace NullableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = 100;
            if (x.HasValue)
            {
                Console.WriteLine("x=" + x);
            }

            x = null;
            if (x.HasValue)
            {
                Console.WriteLine("x=" + x);
            }
            else
            {
                Console.WriteLine("x is empty");
            }

            Nullable<int> y = null;
            y = 200;
            if (y.HasValue)
            {
                Console.WriteLine("y=" + y);
            }






            string s = "hello";
            s = null;


        }
    }
}
