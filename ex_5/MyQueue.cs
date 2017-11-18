using System;

namespace ex_5
{
    public class MyQueue<T>
    {
        private Node head, tail;
        private int count;

        public MyQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Enqueue(T value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public T Dequeue()
        {
            if (head == null)
            {
                throw new Exception("Queue is Empty");
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