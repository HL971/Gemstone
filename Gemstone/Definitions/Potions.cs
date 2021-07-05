using Gemstone.Classes.DTO;
using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Definitions
{
    internal static class Potions
    {
        internal static List<WeightedItem> HealingPotionsList = new List<WeightedItem>
        {
            new WeightedItem(StaticIntegers.CommonRarityWeight * 5, new Potion
            {
                Name = "Healing",
                Description = new List<string>
                {
                    "Regain 2d4+2 Hit Points"
                },
                Rarity = MagicItemRarity.Common,
                Value = 50.0
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight * 5, new Potion
            {
                Name = "Greater Healing",
                Description = new List<string>
                {
                    "Regain 4d4+4 Hit Points"
                },
                Rarity = MagicItemRarity.Uncommon,
                Value = 200.0
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight * 5, new Potion
            {
                Name = "Superior Healing",
                Description = new List<string>
                {
                    "Regain 8d4+8 Hit Points"
                },
                Rarity = MagicItemRarity.Rare,
                Value = 2000.0
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight * 5, new Potion
            {
                Name = "Supreme Healing",
                Description = new List<string>
                {
                    "Regain 10d4+20 Hit Points"
                },
                Rarity = MagicItemRarity.VeryRare,
                Value = 20000.0
            })
        };

        internal static List<WeightedItem> AllPotionsList = new List<WeightedItem>
        {
            new WeightedItem(StaticIntegers.CommonRarityWeight * 5, new Potion
            {
                Name = "Healing",
                Description = new List<string>
                {
                    "Regain 2d4+2 Hit Points"
                },
                Rarity = MagicItemRarity.Common,
                Value = 50.0
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight * 5, new Potion
            {
                Name = "Greater Healing",
                Description = new List<string>
                {
                    "Regain 4d4+4 Hit Points"
                },
                Rarity = MagicItemRarity.Uncommon,
                Value = 200.0
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight * 5, new Potion
            {
                Name = "Superior Healing",
                Description = new List<string>
                {
                    "Regain 8d4+8 Hit Points"
                },
                Rarity = MagicItemRarity.Rare,
                Value = 2000.0
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight * 5, new Potion
            {
                Name = "Supreme Healing",
                Description = new List<string>
                {
                    "Regain 10d4+20 Hit Points"
                },
                Rarity = MagicItemRarity.VeryRare,
                Value = 20000.0
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new Potion
            {
                Name = "Water Breathing",
                Description = new List<string>
                {
                    "You can breath underwater for 1 hour after drinking\n" +
                    "this potion."
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new Potion
            {
                Name = "Vitality",
                Description = new List<string>
                {
                    "When you drink this potion, it removes any exhastion you\n" +
                    "are suffering, and cures any disease or poison affecting\n" +
                    "you.",
                    "For the next 24 hours, you regain the maximum number of\n" +
                    "hit points for any Hit Die you spend."
                },
                Rarity = MagicItemRarity.VeryRare
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new Potion
            {
                Name = "Speed",
                Description = new List<string>
                {
                    "When you drink this potion, you gain the effect of\n" +
                    "the haste spell for 1 minute (No Concentration Required)."
                },
                Rarity = MagicItemRarity.VeryRare
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Acid)",
                Description = new List<string>
                {
                    "You gain resistance to Acid damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Cold)",
                Description = new List<string>
                {
                    "You gain resistance to Cold damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Fire)",
                Description = new List<string>
                {
                    "You gain resistance to Fire damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Force)",
                Description = new List<string>
                {
                    "You gain resistance to Force damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Lightning)",
                Description = new List<string>
                {
                    "You gain resistance to Lightning damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Necrotic)",
                Description = new List<string>
                {
                    "You gain resistance to Necrotic damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Poison)",
                Description = new List<string>
                {
                    "You gain resistance to Poison damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Psychic)",
                Description = new List<string>
                {
                    "You gain resistance to Psychic damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Radiant)",
                Description = new List<string>
                {
                    "You gain resistance to Radiant damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight / 10, new Potion
            {
                Name = "Resistance (Thunder)",
                Description = new List<string>
                {
                    "You gain resistance to Thunder damage for 1 hour"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Mind Reading",
                Description = new List<string>
                {
                    "You gain the effect of the detect thoughts spell\n" +
                    "(Save DC 13)."
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new Potion
            {
                Name = "Longevity",
                Description = new List<string>
                {
                    "When you drink this potion, your physical age is reduced\n" +
                    "by 1d6 + 6 years, to a minimum of 13 years.",
                    "Each time you subsequently drink a Potion of Longevity,\n" +
                    "there is a cumulative 10% chance that you will instead\n" +
                    "age by 1d6 + 6 years."
                },
                Rarity = MagicItemRarity.VeryRare
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Invulnerability",
                Description = new List<string>
                {
                    "You have resistance to all damage for 1 minute"
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new Potion
            {
                Name = "Invisibility",
                Description = new List<string>
                {
                    "You become invisible for 1 hour. Anything you wear\n" +
                    "or carry becomes invisible with you. The effect\n" +
                    "ends early if you attack or cast a spell."
                },
                Rarity = MagicItemRarity.VeryRare
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Heroism",
                Description = new List<string>
                {
                    "You gain 10 temporary hit points that last\n" +
                    "one hour. In addition, you are under the\n" +
                    "effect of the bless spell for one hour.\n" +
                    "(No Concentration Required)"
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new Potion
            {
                Name = "Growth",
                Description = new List<string>
                {
                    "You gain the \"enlarge\" effect of the enlarge/reduce\n" +
                    "spell for 1d4 hours (No Concentration Required)"
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new Potion
            {
                Name = "Giant Strength (Hill)",
                Description = new List<string>
                {
                    "Your strength becomes 21 for 1 hour.",
                    "There is no effect if your strength is equal to or\n" +
                    "greater than 21 when you drink the potion."
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Giant Strength (Frost/Stone)",
                Description = new List<string>
                {
                    "Your strength becomes 23 for 1 hour.",
                    "There is no effect if your strength is equal to or\n" +
                    "greater than 23 when you drink the potion."
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Giant Strength (Fire)",
                Description = new List<string>
                {
                    "Your strength becomes 25 for 1 hour.",
                    "There is no effect if your strength is equal to or\n" +
                    "greater than 25 when you drink the potion."
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new Potion
            {
                Name = "Giant Strength (Cloud)",
                Description = new List<string>
                {
                    "Your strength becomes 27 for 1 hour.",
                    "There is no effect if your strength is equal to or\n" +
                    "greater than 27 when you drink the potion."
                },
                Rarity = MagicItemRarity.VeryRare
            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new Potion
            {
                Name = "Giant Strength (Storm)",
                Description = new List<string>
                {
                    "Your strength becomes 29 for 1 hour.",
                    "There is no effect if your strength is equal to or\n" +
                    "greater than 29 when you drink the potion."
                },
                Rarity = MagicItemRarity.Legendary
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Gaseous Form",
                Description = new List<string>
                {
                    "You gain the effect of the Gaseous Form\n" +
                    "spell for 1 hour (No Concentration Required)",
                    "You may end the effect as a bonus action."
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new Potion
            {
                Name = "Flying",
                Description = new List<string>
                {
                    "You gain a flying speed equal to your walking speed\n" +
                    "for 1 Hour, and can hover.",
                    "If you are in the air when this potion wears off, you fall\n" +
                    "unless you have some other means of staying aloft."
                },
                Rarity = MagicItemRarity.VeryRare
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new Potion
            {
                Name = "Fire Breath",
                Description = new List<string>
                {
                    "After drinking this potion, you can use a bonus\n" +
                    "action to exhale fire at a target within 30 feet\n" +
                    "of you. The target must make a DC 13 Dexterity\n" +
                    "saving throw, taking 4d6 fire damage on a failed\n" +
                    "save, or half as much damage on a successful one.",
                    "The effect ends after you exhale the fire three\n" +
                    "times, or when 1 hour has passed."
                },
                Rarity = MagicItemRarity.Uncommon
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Diminution",
                Description = new List<string>
                {
                    "You gain the \"enlarge\" effect of the enlarge/reduce\n" +
                    "spell for 1d4 hours (No Concentration Required)"
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.CommonRarityWeight, new Potion
            {
                Name = "Climbing",
                Description = new List<string>
                {
                    "You gain a climbing speed equal to your walking speed\n" +
                    "for 1 hour. During this time, you have advantage on\n" +
                    "Str(Athletics) checks you make to climb."
                },
                Rarity = MagicItemRarity.Common
            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new Potion
            {
                Name = "Clairvoyance",
                Description = new List<string>
                {
                    "You gain the effect of the clairvoyance spell."
                },
                Rarity = MagicItemRarity.Rare
            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new Potion
            {
                Name = "Animal Friendship",
                Description = new List<string>
                {
                    "For 1 hour, you may cast the animal friendship spell\n" +
                    "(Save DC 13) at will."
                },
                Rarity = MagicItemRarity.Uncommon
            }),
        };
    }
}
