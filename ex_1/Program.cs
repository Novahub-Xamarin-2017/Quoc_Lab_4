using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = "    Extension     method   exercise    ";
            Console.WriteLine($"This string has {foo.WordCount()} words");
            Console.ReadKey();
        }
    }
}
