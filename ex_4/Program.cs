using System;

namespace ex_4
{
    class Program
    {
        static void Swap<T>(ref T varA, ref T varB)
        {
            T tempt = varA;
            varA = varB;
            varB = tempt;
        }
        static void Main(string[] args)
        {
            // swap integer number
            var numberA = 5;
            var numberB = 10;
            Console.WriteLine($"Before swap : number a = {numberA}, number b = {numberB}");
            Swap(ref numberA,ref numberB);
            Console.WriteLine($"After swap  : number a = {numberA}, number b = {numberB}");
            // swap string
            var stringA = "one";
            var stringB = "two";
            Console.WriteLine($"Before swap : string a = {stringA}, string b = {stringB}");
            Swap(ref stringA,ref stringB);
            Console.WriteLine($"After swap  : string a = {stringA}, string b = {stringB}");
            Console.ReadKey();
        }

    }
}
