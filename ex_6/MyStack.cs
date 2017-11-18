using System;

namespace ex_6
{
    public class MyStack<T>
    {
        private Node head;
        private int count;

        public MyStack()
        {
            head = null;
            count = 0;
        }

        public void Push(T value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            count++;
        }

        public T Pop()
        {
            if (head == null)
            {
                throw new Exception("Stack is Empty");
            }
            T result = head.Data;
            head = head.Next;
            count--;
            return result;
        }

        public int Size() => count;

        public bool IsEmpty() => head == null;

        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data) => Data = data;
        }
    }
}