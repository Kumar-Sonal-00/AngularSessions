namespace SOLID_Principles_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape("circle");
            //AreaCalculator areaCalculator = new AreaCalculator();
            //areaCalculator.CalculateArea(shape);

            //Shape shape2 = new Shape("square");
            //areaCalculator.CalculateArea(shape2);

            //Open/Closed principle
            //Shape shape = new Shape();

            //Circle circle = new Circle();
            //shape.Area(circle);

            //Square square = new Square();
            //shape.Area(square);


            //Liskov Substitution Principle
            IFruit fruit = new Apple();
            fruit.GetColor();

            fruit = new Orange();
            fruit.GetColor();
        }
    }
}
