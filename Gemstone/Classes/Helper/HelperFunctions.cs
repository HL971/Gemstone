using Gemstone.Definitions;
using System.Linq;

namespace Gemstone.Classes.Helper
{
    internal static class HelperFunctions
    {
        /// <returns>True if the string is null or is composed of only whitespace</returns>
        internal static bool IsNullOrWhitespace(this string value)
        {
            return value == null ? true : value == string.Empty ? true : !value.Any(x => !char.IsWhiteSpace(x));
        }

        /// <summary>
        /// Returns a string depicting the size of a gem
        /// </summary>
        internal static string SizeString(this double size)
        {
            if (size < 0.5)
                return StaticStrings.SizeTiny;
            else if (size < 0.75)
                return StaticStrings.SizeSmall;
            else if (size < 1.25)
                return StaticStrings.SizeAverage;
            else if (size < 25)
                return StaticStrings.SizeLarge;
            else if (size < 125)
                return StaticStrings.SizeHuge;
            else if (size < 250)
                return StaticStrings.SizeGargantuan;
            return StaticStrings.SizeColossal;
        }
    }
}
