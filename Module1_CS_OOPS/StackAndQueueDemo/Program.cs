using System.Collections.Generic;

namespace StackAndQueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackDemo();
            QueueDemo();
        }
        static void StackDemo()
        {
            Stack<int> stack = new Stack<int>(); //LIFO
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Peek:" + stack.Peek());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());

            if (stack.Count > 0)
            {
                Console.WriteLine("Pop:" + stack.Pop());
            }
            else
            {
                Console.WriteLine("Stack is EMPTY!");
            }
        }
        static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>(); //FIFO
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);

            Console.WriteLine("Dequeue:"+ queue.Dequeue());
            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Peek:" + queue.Peek());
            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Dequeue:" + queue.Dequeue());
            Console.WriteLine("Dequeue:" + queue.Dequeue());

            
        }
    }
}
