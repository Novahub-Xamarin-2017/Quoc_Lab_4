using System;

namespace ex_3
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2) return false;
            for (int i = (int)Math.Sqrt(number); i >= 2; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
