using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo2
{
    internal class Employee : IComparable<Employee>
    {
        int ecode;
        string ename;
        int salary;
        int deptid;
        public Employee(int ecode,string ename,int salary,int deptid)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
            this.deptid = deptid;
        }

        public int GetSalary()
        {
            return salary;
        }
        public int CompareTo(Employee? other)
        {
            if(this.ecode>other.ecode)
            {
                return 1;
            }
            else if ((this.ecode<other.ecode))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            //return $"{ecode}\t{ename}\t{salary}\t{deptid}";
            return $"Ecode:{ecode}\nEname:{ename}\nSalary:{salary}\nDeptid:{deptid}";
        }
    }

    class SortBySalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if(x.GetSalary()>y.GetSalary())
            {
                return 1;
            }
            else if(x.GetSalary()<y.GetSalary()) 
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
