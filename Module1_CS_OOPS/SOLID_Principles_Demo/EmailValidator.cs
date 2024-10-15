using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Demo
{
    //SRP
    internal class EmailValidator
    {
        public bool ValidateEmail(string email)
        {
            Console.WriteLine("email validation");

            if (email == "admin@gmail.com")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
