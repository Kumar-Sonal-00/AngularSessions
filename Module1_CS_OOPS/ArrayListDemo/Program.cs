using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrLst = new ArrayList();

            arrLst.Add(10);
            arrLst.Add(20);
            arrLst.Add("Ram");
            arrLst.Add(40);
            arrLst.Add(50);

            //int value = (int)arrLst[2]; //InvalidCastException


            Console.WriteLine("Traverse using for loop");
            for (int i = 0; i < arrLst.Count; i++)
            {
                if(i==1)
                {
                    arrLst.Add(1000); //allowed
                    arrLst.Add(2000);
                }
                Console.WriteLine(arrLst[i]);
            }

            arrLst.RemoveAt(2);

            Console.WriteLine("\nTraverse using foreach loop");
            foreach (object item in arrLst)
            {
                if(item is int)
                {
                    int intValue=(int)item;
                    Console.WriteLine(intValue);
                }
                else if(item is string)
                {
                    string strValue=(string)item;
                    Console.WriteLine(strValue);
                }
                //arrLst.Add(3000); //invalid, collection cannot be modified
            }

            Console.WriteLine("\nTraverse using IEnumerator interface");
            IEnumerator ien =arrLst.GetEnumerator();
            while (ien.MoveNext())
            {
                Console.WriteLine(ien.Current);
            }

        }
    }
}
