namespace DelegateCallbackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            task1.DoTask1();
        }
    }

    class Task1
    {
        public void DoTask1()
        {
            Console.WriteLine("Task1 started");
            Task2 t2 = new Task2();
            t2.dlg = new Task2.NotifyDelegate(this.Notify);

            t2.DoTask2();
            Console.WriteLine("Task1 finished");
        }
        void Notify(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class  Task2
    {
        public delegate void NotifyDelegate(string msg);
        public NotifyDelegate dlg = null;
        public void DoTask2()
        {
            Console.WriteLine("\tTask2 started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\texecuting task2:"+i);
            }
           dlg("\tTask2 finished");
        }
    }
}
