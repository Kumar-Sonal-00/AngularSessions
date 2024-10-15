namespace AggregationAndComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Policy policy = new Policy("Jeen Dhara", "Ramnath", "suresh", "raman999@gmail.com");

            policy = null;

            


            Mouse mouse = new Mouse(3, "Logitech");
            Computer computer = new Computer("Lenovo", 57000, mouse);

            computer = null;

            
        }
    }

    
    class Nominee
    {
        string nomineeName;
        string emailid;
        public Nominee(string nomineeName, string emailid)
        {
            this.nomineeName = nomineeName;
            this.emailid = emailid;
        }
    }

    class Policy
    {
        string policyName;
        string policyHolderName;
        Nominee nominee;

        public Policy(string policyName,string holderName,string nomineeName,string emailid)
        {
            this.policyName = policyName;
            this.policyHolderName = holderName;
            this.nominee=new Nominee(nomineeName,emailid); //composition
        }
    }


    class Mouse
    {
        int noOfButtons;
        string brand;
        public Mouse(int noOfButtons,string brand)
        {
            this.noOfButtons = noOfButtons;
            this.brand = brand;
        }
    }

    class Computer 
    {
        string brandName;        
        double cost;
        Mouse mouse;
        public Computer(string brandName,double cost,Mouse mouse)
        {
            this.brandName = brandName;
            this.cost = cost;
            this.mouse= mouse; //aggregation i.e. Uses-mouse
        }
    }
}
