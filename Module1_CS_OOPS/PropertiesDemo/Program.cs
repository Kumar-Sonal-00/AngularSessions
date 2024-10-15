namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Ecode = 101;
            emp.Ename = "Ravi";
            emp.Salary = 1111;
            emp.Deptid = 201;

            Console.WriteLine($"{emp.Ecode}\t{emp.Ename}\t{emp.Salary}\t{emp.Deptid}");

            //Object initializer syntax
            Employee emp2 = new Employee { Ecode=102,Ename="Rahul",Salary=2222,Deptid=202};
            Console.WriteLine($"{emp2.Ecode}\t{emp2.Ename}\t{emp2.Salary}\t{emp2.Deptid}");


        }
    }
}
