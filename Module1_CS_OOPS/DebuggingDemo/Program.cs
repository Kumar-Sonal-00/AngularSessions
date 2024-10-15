namespace DebuggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    //more logical statements
            //    Console.WriteLine("i="+ i);
            //}
            int salary;
            double bonus;
            Console.Write("Enter salary:");
            salary=int.Parse(Console.ReadLine());

            Employee emp = new Employee();
            bonus = emp.GetBonus(salary);
            Console.WriteLine($"Salary:{salary}\tBonus:{bonus}");
        }
    }
}
