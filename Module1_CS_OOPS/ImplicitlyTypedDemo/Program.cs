namespace ImplicitlyTypedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicitly-typed variables
            var x=new int[] {10,20,30,40 };
            


            int y;
            y= 100;            

        }
        //public var Add(var a,var  b) //invalid
        //{ 
        //    return a + b;
        //}
    }
}
class Employee
{
    //var ecode = 1001; //invalid

    public void Display()
    {
        var x = 100;
    }
}