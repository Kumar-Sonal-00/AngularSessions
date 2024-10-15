namespace DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Now;
            Console.WriteLine("Current date and time:" + dt);

            DateTime dt2 = new DateTime(2024, 07, 25);
            Console.WriteLine("custom date and time:" + dt2);

            //format the date and time
            Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            Console.WriteLine(dt.ToString("dd-MMMM-yyyy"));
            Console.WriteLine(dt.ToLongDateString());

            //how to convert a string into datetime
            //Console.Write("Enter your date of joining(e.g. 25-Jul-2024):");
            //string s1 = Console.ReadLine();

            //DateTime d3 = DateTime.ParseExact(s1,"dd-MMM-yyyy",null);
            //Console.WriteLine(d3.ToString("dd/MM/yy"));

            //find the number of days between two dates

            DateTime orderDate = new DateTime(2024, 01, 25);
            DateTime deliveryDate = new DateTime(2024, 02, 05);

            int days = (deliveryDate - orderDate).Days;

            Console.WriteLine("Duration of delivery:"+ days);

            DateTime dt4=DateTime.Now;
            Console.WriteLine(dt4.AddDays(2));

        }
    }
}
