using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    internal class EmployeeRepository
    {
        List<Employee> employees;
        List<Department> departments;
        public EmployeeRepository()
        {
            employees = new List<Employee>
            {
                new Employee{Ecode=101,Ename="Ravi",Salary=1111,Deptid=201},
                new Employee{Ecode=102,Ename="Raman",Salary=2222,Deptid=202},
                new Employee{Ecode=103,Ename="John",Salary=3333,Deptid=202},
                new Employee{Ecode=104,Ename="Tom",Salary=4444,Deptid=203},
                new Employee{Ecode=105,Ename="David",Salary=5555,Deptid=206}
            };

            departments = new List<Department>
            {
                new Department{Deptid=201,Dname="Account",Dhead=107},
                new Department{Deptid=202,Dname="Admin",Dhead=106},
                new Department{Deptid=203,Dname="Sales",Dhead=109},
                new Department{Deptid=205,Dname="LnD",Dhead=108},
            };
        }
        public List<Employee> GetEmps()
        {
            return employees;   
        }
        public List<Department> GetDepts()
        {
            return departments;
        }
    }
}
