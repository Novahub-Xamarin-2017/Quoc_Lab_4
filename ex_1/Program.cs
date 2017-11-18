using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = "    Extension     method   exercise    ";
            Console.WriteLine($"This string has {foo.WordCount()} words");
            Console.ReadKey();
        }
    }
}
