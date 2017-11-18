namespace ex_2
{
    public static class StringExtensions
    {
        public static string CaptionFirst(this string str)
            => str[0].ToString().ToUpper() + str.Substring(1).ToLower();
    }
}