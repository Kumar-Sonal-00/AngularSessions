namespace NUnitTestingDemoLib
{
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b; 
        }
        public int Subtract(int  a, int b)
        { 
            return a - b;
        }
        public int Multiply(int a, int b)
        {  
            return a * b; 
        }
        public double Divide(int a, int b)
        {
            if(b==0)
            {
                throw new DivideByZeroException("Divide By Zero Error");
            }
            return (double)a / b;
        }
    }
}
