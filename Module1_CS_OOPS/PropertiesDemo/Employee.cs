using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Employee
    {      

        //auto-implemented properties
        public int Ecode {  get; set; } 
        public string Ename { get; set; }
        public int Salary {  get; set; }
        public int Deptid { get; set; }
    }
}
