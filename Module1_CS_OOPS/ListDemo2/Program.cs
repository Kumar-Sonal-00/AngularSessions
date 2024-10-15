namespace ListDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmps=new List<Employee>();

            lstEmps.Add(new Employee(103, "Ravi", 3333, 201));
            lstEmps.Add(new Employee(102, "Rahul", 2222, 202));
            lstEmps.Add(new Employee(101, "John", 1111, 202));
            lstEmps.Add(new Employee(104, "David", 4444, 203));
            lstEmps.Add(new Employee(105, "Alex", 5555, 201));

            //lstEmps.Sort(new SortBySalary()); //custom sort
            lstEmps.Sort(); //default sort

            foreach (Employee e in lstEmps)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("==============================");
            }
            Console.WriteLine("\n");
            IEnumerator<Employee> ien= lstEmps.GetEnumerator();
            while (ien.MoveNext())
            {
                Employee e= ien.Current;
                Console.WriteLine(e.ToString());
                Console.WriteLine("==============================");
            }
        }
    }
}
