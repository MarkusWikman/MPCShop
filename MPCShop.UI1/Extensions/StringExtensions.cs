

namespace MPCShop.API.Extensions.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int length)
        {
            if (value.Length < length) return value;
            return value.Trim().Substring(length - 4).Trim() + "...";
            //return value[(length - 4)..] +"...";
        }
    }
}
