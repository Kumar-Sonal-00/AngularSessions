namespace OOPsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance is created
            Student s=new Student(); //allocated the memory and returns
                                     //the reference of the memory
                                     //location
            //Messaging 
            s.SetData(1, "Ramnath", 75);
            s.Display();

        }
    }

    //Define the class
    class Student
    {
        //attributes or fields
        int rollno;
        string name;
        int marks;

        //Behaviors or methods to act on object
        public void SetData(int rollno,string name,int marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.marks = marks;
        }
        public void Display()
        {
            Console.WriteLine($"Rollno:{this.rollno}");
            Console.WriteLine($"Name  :{this.name}");
            Console.WriteLine($"Marks :{this.marks}"); 
            Console.WriteLine($"Result:{this.GetGrade()}");
        }
        string GetGrade()
        {
            string result;
            if (marks < 50)
            {
                result = "Failed";
            }
            else if (marks < 70)
            {
                result = "B-Grade";
            }
            else if (marks < 80)
            {
                result = "A-Grade";
            }
            else
            {
                result = "S-Grade";
            }

            return result;
        }
    }
}
