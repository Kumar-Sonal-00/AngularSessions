using System.Text.RegularExpressions;

namespace RegularExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ecode = "EA101";
            string pattern1 = @"^[aA-zZ]+[0-9]{3}$";


            string mobileNumber = "abcde";

            //string pattern = @"(^[0-9]{5,10}$)";
            string pattern = @"\D{5,10}";

            Regex regEx = new Regex(pattern1);

            if(regEx.IsMatch(ecode))
            {
                Console.WriteLine("valid ecode");
            }
            else
            {
                Console.WriteLine("invalid ecode");
            }
        }
    }
}
