using Cgi;
using Cgi.Blr;
using Cgi.Hyd;
//using N1;
//using N2;
using EmployeeLib;

namespace NMSPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.Display();

            Product product = new Product();
            product.Display();

            Account account = new Account();
            account.Show();

            Admin admin = new Admin();
            admin.Show();

            //use full namespace qualifier if a class is imported more than once
            N1.Sample sample = new N1.Sample();
            sample.Show();

            N2.Sample sample2 = new N2.Sample();
            sample2.Print();

            Employee employee = new Employee();
            employee.Display();

            Department department = new Department();
            department.Display();

            
        }
    }
}

namespace N1
{
    class Sample
    {
        public void Show() { }
    }
}

namespace N2
{
    class Sample
    {
        public void Print() { }
    }
}


