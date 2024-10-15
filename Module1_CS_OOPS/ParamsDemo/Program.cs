namespace ParamsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum:" + Add(10, 20));
            Console.WriteLine("sum:" + Add(10, 20, 30));
            Console.WriteLine("sum:" + Add(10, 20, 30, 40));
            Console.WriteLine("sum:" + Add(10, 20, 30, 40, 50));

            Console.WriteLine(FindNumber(5, 10, 7, 9, 8, 11));
            Console.WriteLine(FindNumber(3, 11, 7, 9, 3, 21,25,70,45));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static int Add(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }


        /// <summary>
        /// Find a number in a given set of numbers
        /// </summary>
        /// <param name="n">number to be searched</param>
        /// <param name="values">set of number in which searching is to be done</param>
        /// <returns>whether the number found or not</returns>
        static string FindNumber(int n, params int[] values)
        {
            foreach (int value in values)
            {
                if (value == n) return "Found";
            }

            return "Not found";
        }

        //static int Add(int a,int b)
        //{
        //    return a + b;
        //}
        //static int Add(int a, int b,int c)
        //{
        //    return a + b + c;
        //}
        //static int Add(int a, int b, int c,int d)
        //{
        //    return a + b + c + d;
        //}
        //static int Add(int a, int b, int c, int d,int e)
        //{
        //    return a + b + c + d + e;
        //}
    }
}
