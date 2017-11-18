using System;

namespace ex_1
{
    public static class StringExtensions
    {
        public static int WordCount(this string sentence)
        => sentence.Split(new char[] {' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}