namespace DelegateDemo2
{
    internal class Program
    {
        delegate int CalculatorDelegate(int a, int b);
        static void Main(string[] args)
        {
            Calculator obj=new Calculator();

            //intialize
            CalculatorDelegate calcDlg = new CalculatorDelegate(obj.Add);
            calcDlg += new CalculatorDelegate(obj.Subtract);
            calcDlg+= new CalculatorDelegate(obj.Multiply);

            //invoke
            int result = calcDlg(10, 20);
            Console.WriteLine(result);

        }
    }

    class Calculator
    {
        public int Add(int a,int b)
        {
            Console.WriteLine("Add is called");
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract is called");
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            Console.WriteLine("Multiply is called");
            return a * b;
        }
    }
}
