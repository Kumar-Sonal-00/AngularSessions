namespace InheritanceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TWO-WHEELER FEATURES");
            TwoWheeler discover = new TwoWheeler("E1", 120);
            discover.DisplayVehicle();
            discover.StartEngine();
            discover.ApplyBrake();
            discover.Stand();

            Console.WriteLine("\nFOUR-WHEELER FEATURES");
            FourWheeler maruti = new FourWheeler("E2", 180);
            maruti.DisplayVehicle();
            maruti.StartEngine();
            maruti.ApplyBrake();
            maruti.Music();
            maruti.Ac();

        }
    }
}
