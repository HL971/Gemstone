using Gemstone.Classes.DTO;
using Gemstone.Classes.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Definitions.Enums
{
    public enum GemstoneEnum
    {
        Diamond,
        Ruby,
        Sapphire,
        Emerald
    }

    public static class GemstoneAdditions
    {
        internal static double GetGemBaseValue(this GemstoneEnum value)
        {
            switch (value)
            {
                case GemstoneEnum.Emerald:
                case GemstoneEnum.Ruby:
                case GemstoneEnum.Sapphire:
                    return 40.0;
                case GemstoneEnum.Diamond:
                    return 25.0;
                default:
                    return 10.0;
            }
        }

        /// <summary>
        /// Assigns static strings to various gemstones
        /// Where the name has whitespace or special characters
        /// </summary>
        public static string GemString(this GemstoneEnum value)
        {
            switch (value)
            {
                default:
                    return value.ToString();
            }
        }

        internal readonly static List<WeightedItem> WeightedGemstoneList =
            new List<WeightedItem>
            {
                new WeightedItem(20, GemstoneEnum.Diamond),
                new WeightedItem(40, GemstoneEnum.Ruby),
                new WeightedItem(40, GemstoneEnum.Sapphire),
                new WeightedItem(40, GemstoneEnum.Emerald)
            };
    }
}
