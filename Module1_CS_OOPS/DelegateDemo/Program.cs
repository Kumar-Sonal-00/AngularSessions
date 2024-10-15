namespace DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app=new App();
            string msg = " Today there is a meeting at 4:30pm, plse make ur presence";
            app.SendMsg(msg);
        
        }
    }

    class App
    {
        //declare
        delegate void MessageDelegate(string msg);
        public void SendMsg(string msg)
        {
            //initialize
            //multi-cast delegate
            MessageDelegate dlg = new MessageDelegate(Account.SendMessageToAccount);
            dlg += new MessageDelegate(Sales.SendMessageToSales);
            dlg += new MessageDelegate(Admin.SendMessageToAdmin);

            //invoke
            dlg(msg);

            //dlg=new MessageDelegate(Sales.SendMessageToSales);
            //dlg(msg);

            //dlg=new MessageDelegate(Admin.SendMessageToAdmin);
            //dlg(msg);

        }
    }
    class Account
    {
        public static void SendMessageToAccount(string msg)
        {
            Console.WriteLine("Account:" + msg);
        }
    }
    class Sales
    {
        public static void SendMessageToSales(string msg)
        {
            Console.WriteLine("Sales:" + msg);
        }
    }
    class Admin
    {
        public static void SendMessageToAdmin(string msg)
        {
            Console.WriteLine("Admin:" + msg);
        }
    }
}
