using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    internal class Vehicle
    {
        string engine;
        int maxSpeed;
       
        public Vehicle(string engine,int maxSpeed)
        {
            this.engine = engine;
            this.maxSpeed = maxSpeed;
        }
        public void ApplyBrake()
        {
            Console.WriteLine("Brake applied");
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public void DisplayVehicle()
        {
            Console.WriteLine($"Engine:{engine}\tMax Speed:{maxSpeed}");
        }
    }
}
