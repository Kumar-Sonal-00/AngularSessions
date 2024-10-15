using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Demo
{
    //SRP
    internal class Customer
    {
        public void Register(string cname,string city,string email)
        {
            Console.WriteLine("Registration successfull");
        } 
        public void PlaceOrder()
        {
            Console.WriteLine("Order has been placed");
        }
    }
}
