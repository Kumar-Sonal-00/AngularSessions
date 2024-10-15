namespace SearchingAndSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 7, 9, 10, 11, 15, 20 };
            Console.WriteLine(BinarySearch(numbers, 9));
            Console.WriteLine(BinarySearch(numbers, 4));

            Console.WriteLine(LinearSearch(numbers, 9));
            Console.WriteLine(LinearSearch(numbers, 4));

            //BubbleSort(numbers);
            //SelectionSort(numbers);
            InsertionSort(numbers);
        }
        static bool BinarySearch(int[] numbers, int value)
        {
            int len = numbers.Length;
            int l = 0;
            int r = len - 1;
            int m;

            while (r >= l)
            {
                m = (r + l) / 2;
                if (numbers[m] == value)
                {
                    return true;
                }
                else if (numbers[m] > value)
                {
                    r = (m - 1);
                }
                else
                {
                    l = m + 1;
                }
            }
            return false;
        }

        static bool LinearSearch(int[] numbers, int value)
        {
            foreach (var item in numbers)
            {
                if (item == value)
                    return true;
            }

            return false;
        }

        static void BubbleSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for(int j = 0;j<numbers.Length-1;j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        //swap j and j+1
                        int temp=numbers[j];
                        numbers[j]=numbers[j+1]; 
                        numbers[j+1]=temp;
                    }
                }
            } 
            PrintValues(numbers);
        }

        static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n-1; i++)
            {
                int min_idx = i;
                for (int j = i+1; j < n; j++)
                {
                    if (numbers[j] < numbers[min_idx])
                    {
                        min_idx = j;
                    }
                }
                //swap the found min element with the first 
                int temp=numbers[min_idx];
                numbers[min_idx] = numbers[i];
                numbers[i] = temp;
            }

            PrintValues(numbers);
        }
        static void PrintValues(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }
        }

        static void InsertionSort(int[] numbers)
        {
            int n=numbers.Length;
            for(int i=1;i<n;i++)
            {
                int key=numbers[i];
                int j = i - 1;

                while(j>=0 && numbers[j]>key)
                {
                    numbers[j + 1] = numbers[i];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
            PrintValues(numbers);
        }
    }    
}
