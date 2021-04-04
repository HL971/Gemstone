using Gemstone.Classes.DTO;
using System.Collections.Generic;

namespace Gemstone.Definitions.Enums
{
    public enum GemColor
    {
        UNDEFINED, // Used if a gem only has one valid color
        Clear,
        Red,
        Blue,
        Green,
        Yellow,
        Brown,
        Grey,
        Pink,
        Purple,
        White,
        Orange
    }

    internal static class GemstoneColorAdditions
    {
        internal static string ColorString(this GemColor gem)
        {
            switch (gem)
            {
                case GemColor.UNDEFINED:
                    return null;
                default:
                    return gem.ToString();
            }
        }

        internal readonly static List<WeightedItem> DiamondColors =
            new List<WeightedItem>
            {
                new WeightedItem(40, GemColor.Yellow),
                new WeightedItem(30, GemColor.Brown),
                new WeightedItem(5, GemColor.Clear),
                new WeightedItem(5, GemColor.Blue),
                new WeightedItem(5, GemColor.Green),
                new WeightedItem(5, GemColor.Red),
                new WeightedItem(5, GemColor.Pink),
                new WeightedItem(5, GemColor.Purple)
            };

        internal readonly static List<WeightedItem> SapphireColors =
            new List<WeightedItem>
            {
                new WeightedItem(80, GemColor.Blue),
                new WeightedItem(5, GemColor.White),
                new WeightedItem(5, GemColor.Grey),
                new WeightedItem(5, GemColor.Green),
                new WeightedItem(5, GemColor.Yellow),
                new WeightedItem(5, GemColor.Orange),
                new WeightedItem(5, GemColor.Purple),
            };
    }
}
