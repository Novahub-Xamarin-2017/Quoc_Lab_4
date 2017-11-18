using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime number from 2 to 100 : ");
            for (int i = 2; i <= 100; i++)
            {
                if (i.IsPrime())
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
