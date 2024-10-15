namespace DynamicPolymorphismAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh; //=new Shape(); abstract class instance is not allowed

            sh = new Circle();
            sh.Area();
            sh.Perimeter();
            sh.FillColor();

            sh = new Square();
            sh.Area();
            sh.Perimeter();
            sh.FillColor();
        }
    }

    abstract class Shape
    {
        public abstract void Area();
        public abstract void Perimeter();

        public void FillColor()
        {
            Console.WriteLine("FillColor");
        }
    }
    class Circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Circle");
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle");
        }
    }
    class Square : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Square");
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter of Square"); ;
        }
    }
}
