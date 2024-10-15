namespace OutRefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 4000;
            double bonus = 0;

            CalculateBonus(salary, out bonus);
            Console.WriteLine($"Salary:{salary}\tBonus:{bonus}");
        }
        static void CalculateBonus(int salary, out double bonus) 
        {
            if (salary > 5000)
            {
                bonus = 0.1 * salary;
            }
            else
            {
                bonus = 0.2 * salary;
            }
        }
    }
}
