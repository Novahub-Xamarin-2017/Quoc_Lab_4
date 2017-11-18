using System;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = GetInputStack();
            while (!stack.IsEmpty())
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.ReadKey();
        }

        private static MyStack<int> GetInputStack()
        {
            var stack = new MyStack<int>();
            stack.Push(15);
            stack.Push(20);
            stack.Push(25);
            return stack;
        }
    }
}
