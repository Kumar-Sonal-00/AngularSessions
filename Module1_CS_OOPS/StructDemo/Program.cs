namespace StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address adr1=new Address("#251","Bangalore","Karnataka","560054");
            Console.WriteLine(adr1.ToString());

            Address adr2 = adr1; //data will be copied not reference
            adr2.SetPinCode("560056");
            Console.WriteLine("");

            Console.WriteLine(adr1.ToString());
            Console.WriteLine("");
            Console.WriteLine(adr2.ToString());


        }
    }
}

struct Address
{
    string Hno;
    string City;
    string State;
    string Pin;
    public Address(string hno,string city,string state,string pin)
    {
        Hno= hno;
        City= city;
        State= state;
        Pin= pin;
    }

    public override string ToString()
    {
        return $"House no.:{Hno}\nCity:{City}\nState:{State}\nPin:{Pin}";
    }

    public void SetPinCode(string pin)
    {
        Pin = pin;
    }
   
}
