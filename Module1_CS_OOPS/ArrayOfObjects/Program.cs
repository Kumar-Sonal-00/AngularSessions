namespace ArrayOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array of employee
            Employee[] emps=new Employee[3];

            //assign the data for each employee
            for (int i = 0; i < emps.Length; i++)
            {  
                Console.Write("Enter ecode:");
                int ecode=int.Parse(Console.ReadLine());
                Console.Write("Enter name:");
                string ename=Console.ReadLine();
                Console.Write("Enter salary:");
                int salary = int.Parse(Console.ReadLine());
                Console.Write("Enter deptid:");
                int deptid = int.Parse(Console.ReadLine());

                emps[i] = new Employee(ecode, ename, salary, deptid);
                
                //emps[i].SetData(ecode, ename, salary, deptid);
            }

            //access the array
            foreach (Employee emp in emps)
            {
                emp.Display();
            }

        }
    }

    class Employee
    {
        int ecode;
        string ename;
        int salary;
        int deptid;

        //constructor 
        public Employee(int ecode,string ename,int salary,int deptid)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
            this.deptid = deptid;
            Console.WriteLine("constructor called");
        }
        public void Display()
        {
            Console.WriteLine($"{ecode}\t{ename}\t{salary}\t{deptid}");
        }

        //destructor
        ~Employee()
        {
            Console.WriteLine("destructor called");
        }
    }
}
