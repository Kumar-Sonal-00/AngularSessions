namespace CtorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee(101, "Ravi", 1111, 201);            
            Employee emp2 = new Employee(102, "Ram", 2222, 202);
            Employee emp3 = new Employee(103, "Rahul", 3333, 203);

            emp1.Display();
        }
    }

    class Employee
    {
        int ecode;
        string ename;
        int salary;
        int deptid;
        static string companyName;

        static Employee()
        {
            companyName = "CGI";
            Console.WriteLine("static constructor called");
        }
        public Employee(int ecode,string ename,int salary,int deptid/*,string company*/)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
            this.deptid = deptid;
            //companyName = company;
            Console.WriteLine("non-static constructor called");
        }    
        public void Display()
        {
            Console.WriteLine($"{ecode}\t{ename}\t{salary}\t{deptid}\t{companyName}");
        }
        public static void Print()
        {            
            Console.WriteLine($"{companyName}");
        }
    }
}
