namespace Gemstone.Definitions.Enums
{
    public enum MagicItemRarity
    {
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
                default:
                    return rarity.ToString();
            }
        }
    }
}