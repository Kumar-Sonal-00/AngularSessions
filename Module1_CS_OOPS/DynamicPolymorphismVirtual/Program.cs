namespace DynamicPolymorphismVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks = 35;
            //declare the variable of base type
            University u;

            //bind to University
            u=new University();
            Console.WriteLine("Result at University:" + u.GetResult(marks));

            //bind to College1
            u = new College1();
            Console.WriteLine("Result at College1:" + u.GetResult(marks));


            //bind to College2
            u = new College2();
            Console.WriteLine("Result at College2:" + u.GetResult(marks));
        }
    }

    class University
    {
        public virtual string GetResult(int marks)
        {
            string result = "PASSED";
            if (marks < 50)
            {
                result = "FAILED";
            }

            return result;
        }
    }

    class College1 : University
    {
        public override string GetResult(int marks)
        {
            string result = "PASSED";
            if (marks < 60)
            {
                result = "FAILED";
            }

            return result;
        }
    }

    class College2 : University
    {
        public override string GetResult(int marks)
        {
            string result = "PASSED";
            if (marks < 40)
            {
                result = "FAILED";
            }

            return result;
        }
    }
}
