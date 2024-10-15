using System;

namespace ParseVsConvertVsTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Parse
            //Parse is used to convert awlays from a string to target type
            //string x = null;// "100abc";
            //int n=int.Parse(x);
            //If the x is not the valid value, it gives FormatException
            //If x is null, it gives ArgumentNullException, not 0 nor FormatException

            //2.TryParse
            //TryParse is used to convert awlays from a string to target type
            //It returns true if parsing is successfull else false.
            //if value is invalid or null, it gives default value e.g. 0 for integer

            string y = null;// "100abc";
            int result;
            if (int.TryParse(y, out result))
            {
                //Console.WriteLine(result);
            }
            else
            {
                //Console.WriteLine("parsing failed:"+result);
            }

            //3. Convert
            //it is used to convert from one compatible type to another type,
            //need not be necessarily string type unlike Parse and TryParse

            int a = 100;
            string s = null;// "100.25abc";
            double d=Convert.ToDouble(s);
            Console.WriteLine(d);

            //if data is invalid, we get FormatException
            //if data is null value, it gives default value like 0 for double or int
        }
    }
}
