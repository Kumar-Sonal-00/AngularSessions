namespace cs_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take user input of salary and calculate the bonus based on assumption
            int salary;
            double bonus;
     
            //Take user input
            Console.Write("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());

            //calculate bonus
            if(salary>=5000)
            {
                bonus = salary * 0.1;
            }
            else
            {
                bonus = salary * 0.2;
            }

            //display the bonus
            //using string concatenation
            Console.WriteLine("Bonus of salary " + salary +" is " + bonus);

            //using positional parameters
            Console.WriteLine("Bonus of salary {0} is {1:000}", salary, bonus);

            //using string interpolation
            Console.WriteLine($"Bonus of salary {salary} is {bonus}");

            //using String.Format 
            string output = String.Format("Bonus of salary {0} is {1}", salary, bonus);
            Console.WriteLine(output);
        }
    }
}
