namespace MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result, choice;
            Console.Write("Enter n1:");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Enter n2:");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter choice(1.Add 2.Subtract 3.Multiply):");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                result = Add(n1, n2);
                Console.WriteLine("Sum:" + result);
            }
            else if (choice == 2)
            {
                result = Subtract(n1, n2);
                Console.WriteLine("Subtraction:" + result);
            }
            else if (choice == 3)
            {
                result = Multiply(n1, n2);
                Console.WriteLine("Product:" + result);
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }
        static int Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        static int Subtract(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }
        static int Multiply(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
    }
}
