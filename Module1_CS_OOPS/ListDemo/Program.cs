namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lstNums=new List<int>();

            lstNums.Add(20);
            lstNums.Add(10);
            lstNums.Add(30);
            lstNums.Add(50);
            lstNums.Add(40);
            //sorting the collection
            lstNums.Sort(); //default sort

            foreach (int item in lstNums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================");

            for (int i = 0; i < lstNums.Count; i++)
            {
                Console.WriteLine(lstNums[i]);
            }
            IEnumerator<int> iter = lstNums.GetEnumerator();
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }
    }
}
