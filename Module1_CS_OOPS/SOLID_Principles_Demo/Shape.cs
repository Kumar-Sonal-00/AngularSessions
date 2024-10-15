using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Demo
{
    interface IShape
    {
        void Area();
    }

    class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Circle:pi*radius*radius");
        }
    }
    class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of square: side*side");
        }
    }





    internal class Shape
    {        
        public void Area(IShape shape)
        {
            shape.Area();
        }
    }
}
