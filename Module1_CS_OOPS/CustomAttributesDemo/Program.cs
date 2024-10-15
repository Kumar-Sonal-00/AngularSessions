using System.Reflection;

namespace CustomAttributesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();

            Type type=sample.GetType();
            Console.WriteLine("Custom attribues on Class");
            foreach (Attribute attribute in type.GetCustomAttributes())
            {
                Console.WriteLine(attribute);
            }


            MethodInfo[] methods =type.GetMethods();
            Console.WriteLine("Custom attributes on methods of Class 'Sample'");

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method:" + method.Name);
                foreach (Attribute attr in method.GetCustomAttributes())
                {
                    Console.WriteLine("\t"+attr);
                }
            }
            


        }
    }

    [My]
    class Sample
    {        
        int id;        
        public string Name { get; set; }    

        [My]
        public void Display()
        {
            Console.WriteLine("Display");
        }
    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class MyAttribute : Attribute
    {

    }
}
