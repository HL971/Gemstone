using Gemstone.Classes.DTO;
using System.Collections.Generic;

namespace Gemstone.Definitions.Enums
{
    public enum GemstoneEnum
    {
        Diamond,
        Ruby,
        Sapphire,
        Emerald,
        Aquamarine,
        Heliotrope,
        FireAgate,
        IrisAgate,
        Garnet,
        Jade,
        Moonstone,
        Pearl,
        Peridot,
        Amethyst,
        Citrine,
        Spinel,
        Topaz,
        Rubellite,
        Tourmaline,
        Turquoise
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
                case GemstoneEnum.Amethyst:
                    return 25.0;
                case GemstoneEnum.Aquamarine:
                case GemstoneEnum.Garnet:
                case GemstoneEnum.Peridot:
                case GemstoneEnum.Topaz:
                case GemstoneEnum.Rubellite:
                    return 20.0;
                case GemstoneEnum.Tourmaline:
                case GemstoneEnum.Spinel:
                case GemstoneEnum.Moonstone:
                    return 15.0;
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
                case GemstoneEnum.Heliotrope:
                    return "Heliotrope (Bloodstone)";
                case GemstoneEnum.FireAgate:
                    return "Fire Agate";
                case GemstoneEnum.IrisAgate:
                    return "Iris Agate";
                default:
                    return value.ToString();
            }
        }

        internal readonly static List<GemstoneEnum> UncutStones =
            new List<GemstoneEnum>
            {
                GemstoneEnum.Moonstone,
                GemstoneEnum.Pearl,
                GemstoneEnum.Turquoise
            };

        internal readonly static List<WeightedItem> WeightedGemstoneList =
            new List<WeightedItem>
            {
                new WeightedItem(20, GemstoneEnum.Diamond),
                new WeightedItem(40, GemstoneEnum.Ruby),
                new WeightedItem(40, GemstoneEnum.Sapphire),
                new WeightedItem(40, GemstoneEnum.Emerald),
                new WeightedItem(200, GemstoneEnum.Aquamarine),
                new WeightedItem(30, GemstoneEnum.Heliotrope),
                new WeightedItem(40, GemstoneEnum.FireAgate),
                new WeightedItem(40, GemstoneEnum.IrisAgate),
                new WeightedItem(250, GemstoneEnum.Garnet),
                new WeightedItem(60, GemstoneEnum.Jade),
                new WeightedItem(300, GemstoneEnum.Moonstone),
                new WeightedItem(120, GemstoneEnum.Pearl),
                new WeightedItem(250, GemstoneEnum.Peridot),
                new WeightedItem(60, GemstoneEnum.Amethyst),
                new WeightedItem(120, GemstoneEnum.Citrine),
                new WeightedItem(400, GemstoneEnum.Spinel),
                new WeightedItem(250, GemstoneEnum.Topaz),
                new WeightedItem(200, GemstoneEnum.Rubellite),
                new WeightedItem(300, GemstoneEnum.Tourmaline),
                new WeightedItem(40, GemstoneEnum.Turquoise)
            };
    }
}
