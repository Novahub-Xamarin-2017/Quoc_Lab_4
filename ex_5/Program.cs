using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = GetInputQueue();
            while (!queue.IsEmpty())
            {
                Console.Write(queue.Dequeue() + " ");
            }
            Console.ReadKey();
        }

        private static MyQueue<int> GetInputQueue()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(25);
            return queue;
        }
    }
}
