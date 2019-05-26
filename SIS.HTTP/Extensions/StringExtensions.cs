namespace SIS.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string text) => text[0].ToString().ToUpper() + text.Substring(1).ToLower();
    }
}
