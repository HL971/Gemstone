using System;

namespace Gemstone.Definitions.Enums
{
    public enum MagicItemRarity
    {
        Undefined,
        Common,
        Uncommon,
        Rare,
        VeryRare,
        Legendary
    }

    internal static class MagicItemRarityAdditions
    {
        internal static string RarityString(this MagicItemRarity rarity)
        {
            switch (rarity)
            {
                case MagicItemRarity.VeryRare:
                    return "Very Rare";
                case MagicItemRarity.Undefined:
                    throw new IndexOutOfRangeException("Unexpected Error getting rarity string - Rarity Undefined: " + rarity.ToString());
                default:
                    return rarity.ToString();
            }
        }
    }
}