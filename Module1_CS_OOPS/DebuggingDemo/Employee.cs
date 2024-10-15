using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingDemo
{
    internal class Employee
    {
        //if salary less than or equal to 5000 , bonus 10% of salary
        //else 20% of salary
        public double GetBonus(int salary)
        {
            double bonus;
            if(salary<=5000)
            {
                bonus = 0.1 * salary;
            }
            else
            {
                bonus = 0.2 * salary;
            }

            return bonus;
        }
    }
}
