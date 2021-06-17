using Gemstone.Classes.DTO;
using Gemstone.Classes.Functional;
using Gemstone.Definitions.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Gemstone.Classes.Logic
{
    /// <summary>
    /// Home for any static method that is generated randomly
    /// </summary>
    internal static class ValueGenerator
    {
        private static readonly Random _rng = new Random();
        private static readonly GemstoneCutEnum[] _gemstoneCuts = (GemstoneCutEnum[])Enum.GetValues(typeof(GemstoneCutEnum));

        /// <summary>
        /// The same formula is used for random clarity/cut/color grade values
        /// </summary>
        internal static double GetCommonRandomVariable()
        {
            return (100.0 - 600.0 * Math.Pow(_rng.NextDouble() - 0.5, 3))/100.0;
        }

        internal static double GetRandomSizeValue()
        {
            return Math.Round(Math.Pow(2400, 0.821887 - _rng.NextDouble()), 2);
        }

        /// <summary>
        /// Returns a random value for the gemstone type
        /// </summary>
        internal static GemstoneEnum GetRandomGemstoneType()
        {
            return (GemstoneEnum)GetRandomWeightedItem(GemstoneAdditions.WeightedGemstoneList);
        }

        /// <summary>
        /// Returns a random value for the cut of a gemstone
        /// </summary>
        internal static GemstoneCutEnum GetRandomGemstoneCut()
        {
            return _gemstoneCuts[_rng.Next(_gemstoneCuts.Length)];
        }

        internal static GemColor GetRandomGemstoneColor(GemstoneEnum gem)
        {
            switch (gem)
            {
                case GemstoneEnum.Diamond:
                    return (GemColor)GetRandomWeightedItem(GemstoneColorAdditions.DiamondColors);
                case GemstoneEnum.Sapphire:
                    return (GemColor)GetRandomWeightedItem(GemstoneColorAdditions.SapphireColors);
                case GemstoneEnum.Garnet:
                    return (GemColor)GetRandomWeightedItem(GemstoneColorAdditions.GarnetColors);
                case GemstoneEnum.Peridot:
                    return (GemColor)GetRandomWeightedItem(GemstoneColorAdditions.PeridotColors);
                case GemstoneEnum.Spinel:
                    return (GemColor)GetRandomWeightedItem(GemstoneColorAdditions.SpinelColors);
                case GemstoneEnum.Rubellite:
                    return (GemColor)GetRandomWeightedItem(GemstoneColorAdditions.RubelliteColors);
                default:
                    return GemColor.UNDEFINED;
            }
        }

        /// <summary>
        /// Returns a random item from the provieded weighted list
        /// Returns 0 if not a list of WeightedItem
        /// </summary>
        private static object GetRandomWeightedItem(IEnumerable weightedList)
        {
            if (!(weightedList is List<WeightedItem> correctTypeList))
                return 0;

            var totalWeight = correctTypeList.Sum(x => x.Weight);

            var random = _rng.Next(totalWeight);

            var currentWeight = 0;
            for (int x = 0; x < correctTypeList.Count; x++)
            {
                currentWeight += correctTypeList[x].Weight;
                if (random < currentWeight)
                    return correctTypeList[x].Value;
            }

            return 0;
        }

        internal static int RollDice(Die dice)
        {
            var result = 0;

            for (int x = 0; x < dice.Count; x++)
            {
                result += (_rng.Next(dice.Size) + 1);
            }

            return result;
        }

        internal static WeaponType GetRandomWeaponType(List<WeaponType> weaponTypes)
        {
            return weaponTypes[_rng.Next(weaponTypes.Count)];
        }
    }
}
