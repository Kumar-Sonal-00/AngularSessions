using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    internal class FourWheeler : Vehicle
    {
        public FourWheeler(string engine,int maxSpeed) 
            : base(engine,maxSpeed) //constructor chaining
        {
            
        }
        public void Music()
        {
            Console.WriteLine("Music on");
        }
        public void Ac()
        {
            Console.WriteLine("AC on");
        }
    }
}
