using Gemstone.Classes.DTO;
using System.Collections.Generic;

namespace Gemstone.Definitions.Enums
{
    public enum MetalEnum
    {
        Copper,
        Bronze,
        Brass,
        Iron,
        Steel,
        Gold,
        Silver,
        Electrum,
        Platinum,
        Mithril,
        Adamantine,
        Lead,
        Tin,
        Zinc
    }

    public static class MetalAdditions
    {
        internal static double GetMetalBaseValue(this MetalEnum value)
        {
            switch (value)
            {
                case MetalEnum.Adamantine:
                    return 15000.0;
                case MetalEnum.Mithril:
                    return 12000.0;
                case MetalEnum.Platinum:
                    return 10000.0;
                case MetalEnum.Gold:
                    return 1000.0;
                case MetalEnum.Electrum:
                    return 200.0;
                case MetalEnum.Silver:
                    return 100.0;
                case MetalEnum.Brass:
                case MetalEnum.Bronze:
                case MetalEnum.Steel:
                    return 15.0;
                case MetalEnum.Copper:
                    return 10.0;
                default:
                    return 5.0;
            }
        }
        
        internal readonly static List<WeightedItem> WeightedMetalVeinList =
            new List<WeightedItem>
            {
                new WeightedItem(50, MetalEnum.Copper),
                new WeightedItem(100, MetalEnum.Iron),
                new WeightedItem(20, MetalEnum.Gold),
                new WeightedItem(30, MetalEnum.Silver),
                new WeightedItem(5, MetalEnum.Platinum),
                new WeightedItem(1, MetalEnum.Mithril),
                new WeightedItem(1, MetalEnum.Adamantine),
                new WeightedItem(20, MetalEnum.Tin),
                new WeightedItem(20, MetalEnum.Zinc),
                new WeightedItem(50, MetalEnum.Lead)
            };

        internal readonly static List<WeightedItem> WeightedMetalMaterialList =
            new List<WeightedItem>
            {
                new WeightedItem(75, MetalEnum.Copper),
                new WeightedItem(40, MetalEnum.Bronze),
                new WeightedItem(20, MetalEnum.Brass),
                new WeightedItem(150, MetalEnum.Iron),
                new WeightedItem(50, MetalEnum.Steel),
                new WeightedItem(20, MetalEnum.Gold),
                new WeightedItem(40, MetalEnum.Silver),
                new WeightedItem(10, MetalEnum.Electrum),
                new WeightedItem(5, MetalEnum.Platinum),
                new WeightedItem(1, MetalEnum.Mithril),
                new WeightedItem(1, MetalEnum.Adamantine),
                new WeightedItem(5, MetalEnum.Lead)
            };
    }
}
