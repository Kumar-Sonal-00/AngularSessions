namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleDimensionArray();
            //RectangularArray();
            JaggedArray();
        }
        static void SingleDimensionArray()
        {
            //declare array
            //data-type[] name-of-array=new data-type[size]
            //int[] numbers = new int[5];  //0-4
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };
            //int[] numbers = { 10, 20, 30, 40, 50 };

            Console.Write("Enter number of items needed:");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number[{i + 1}]:");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            //assign values
            //numbers[0] = 10; numbers[1] = 20; numbers[2] = 30;
            //numbers[3] = 40; numbers[4] = 50;

            //access the values
            //Console.WriteLine(numbers[0]);
            Console.WriteLine("Traversing array using for loop");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void RectangularArray()
        {
            //int[,] numbers= new int[3,4];
            //numbers[0, 0] = 10; numbers[0,1] = 20; numbers[0, 2] = 30; numbers[0, 3] = 40;
            //numbers[1, 0] = 50; numbers[1, 1] = 60; numbers[1, 2] = 70; numbers[1, 3] = 80;
            //numbers[2, 0] = 90; numbers[2, 1] = 95; numbers[2, 2] = 98; numbers[2, 3] = 99;
            //OR
            //int[,] numbers = new int[,] { 
            //                                { 10,20,30},
            //                                {40,50,60 },
            //                                {70,80,90 } 
            //                            };
            //OR
            int[,] numbers = {
                                { 10,20,30},
                                {40,50,60 },
                                {70,80,90 }
                             };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine("");
            }

        }

        static void JaggedArray()
        {
            //int[][] jarr = new int[3][];
            //jarr[0] = new int[] { 10, 20 };
            //jarr[1] = new int[] { 10, 20, 30, 40 };
            //jarr[2] = new int[] { 10, 20, 30 };
            //OR
            int[][] jarr = new int[][] { 
                                         new int[] { 10, 20 } , 
                                         new int[] { 10, 20, 30, 40 } , 
                                         new int[] { 10, 20, 30 } 
                                       };

            for (int i = 0; i < jarr.GetLength(0); i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
