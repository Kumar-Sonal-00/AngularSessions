namespace DynamicPolymosphismInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape sh; //instance not allowed

            sh = new Circle();
            sh.Area();
            sh.Perimeter();

            sh = new Square();
            sh.Area();
            sh.Perimeter();
        }
    }

    interface IShape
    {
        void Area();
        void Perimeter();
    }

    class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Circle");
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle");
        }
    }
    class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Square");
        }

        public void Perimeter()
        {           
            Console.WriteLine("Perimeter of Circle");
        }
    }

    class Parent
    {
        private int priv;

        internal int i;
        protected internal int pi;
        public int pub;

        protected int pro;

    }

    class Child : Parent
    {
        public void Show()
        {
            //p = 100;
        }
    }
}
