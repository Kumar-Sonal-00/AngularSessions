namespace DeafultAndNamedParameters
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(10, 20, 30));
            Console.WriteLine(AddNumbers(100, 200));
            Console.WriteLine(AddNumbers(100));
            Console.WriteLine(AddNumbers(5));

            Task1(a:10,d:20,s:"hello",b:2.5,c:"world"); //named arguments

        }
        static int AddNumbers(int a,int b=0,int c=0) //default values
        {
            return a + b + c;
        }

        static void Task1(string s,int a,double b,string c,int d)
        {
            //TODO
        }
    }
}
