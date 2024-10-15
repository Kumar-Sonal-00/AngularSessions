using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    /// <summary>
    /// This class define employee details
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// employee code 
        /// </summary>
        public int Ecode { get; set; }
        /// <summary>
        /// Name of the employee
        /// </summary>
        public string Ename { get; set; }
        public int? Salary {  get; set; }
        public int Deptid { get; set; }

        public override string ToString()
        {
            return $"{Ecode}\t{Ename}\t{Salary}\t{Deptid}";
        }
    }
}
