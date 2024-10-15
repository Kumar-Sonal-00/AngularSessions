using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    internal class TwoWheeler : Vehicle
    {
        public TwoWheeler(string engine,int maxSpeed) 
            : base(engine,maxSpeed)
        {
            
        }
        public void Stand()
        {
            Console.WriteLine("Put stand");
        }
    }
}
