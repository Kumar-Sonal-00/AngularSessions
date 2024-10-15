namespace LambdaOperator
{
    internal class Program
    {
        delegate int MathsDelegate(int a, int b);
        static void Main(string[] args)
        {

            MathsDelegate dlg = new MathsDelegate(Calculator.Add);
            int result = dlg(10, 20);
            Console.WriteLine("using named method, Sum:" + result);

            //we can bind an anonymous method
            dlg=new MathsDelegate(delegate (int a, int b)
            {
                return a + b;
            });
            result = dlg(10, 20);
            Console.WriteLine("using anonymous method, Sum:" + result);

            //using lambda operator
            dlg = new MathsDelegate((a,b)=>{return a + b;});
            result = dlg(10, 20);
            Console.WriteLine("using lambda, Sum:" + result);

            dlg = new MathsDelegate((a, b) => { return a / b; });
            Console.WriteLine("Division:" + dlg(100, 5));
           
        }
    }

    class Calculator
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }


    }
}
