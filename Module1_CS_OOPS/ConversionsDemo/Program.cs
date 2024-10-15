namespace ConversionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a. value-to-value
            int x = 100;
            long l = x; //implicit, no need to typecast            

            int y = (int)l; //explicit, data truncation may happen
            Console.WriteLine($"l={l}");
            Console.WriteLine($"y={y}");

            //b. value-to-reference
            int a = 100;
            object o = a; //Boxing, implicit, no need to typecast

            //c. reference to value
            int b = (int)o; //Unboxing, explicit, needs type-casting

            //d. reference to reference

            Parent parent = new Parent();
            Child ch = (Child)parent; //explicit

            Child ch2 = new Child();
            parent = ch2; //implicit, trucation happens from child as we 
            //only get overridden methods from child    

        }
    }

    class Parent
    {
        public void Method1() { }
        public virtual void Display() { }
    }
    class Child : Parent
    {
        public override void Display()
        {
            
        }

        public void Task()
        {

        }
    }
}
