namespace IsAndAsOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"is" is a comparison operator to check the type of an object

            object[] arr = new object[] { 10,20,"a","b","c"};

            foreach (object o in arr)
            {
                if (o is string)
                {
                    string s = (string)o;
                    Console.WriteLine(s.ToUpper());
                }
            }
                Person[] people = new Person[3];
                
                people[0] = new Student();
                people[1] = new Faculty();
                people[2] = new Student();

                for (int i = 0; i < people.Length; i++)
                {
                    if(people[i] is Student)
                    {
                        Student s= people[i] as Student;
                        s.Register();
                    }
                    else
                    {
                        Faculty f=people[i] as Faculty;
                        f.AttendInterview();
                    }
                }
            }
        }
    }
    class Person
    {

    }
    class Student : Person
    {
        public void Register()
        {
            Console.WriteLine("Student-Registered");
        }
    }
    class Faculty : Person
    {
        public void AttendInterview()
        {
            Console.WriteLine("Faculty:attending interview");
        }
    }

