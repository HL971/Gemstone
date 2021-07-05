using Gemstone.Classes.DTO;
using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Definitions
{
    internal static class MagicWeapons
    {
        /// <summary>
        /// A static list of all possible magic weapons
        /// </summary>
        internal static List<WeightedItem> MagicWeaponList = new List<WeightedItem>
        { 
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO     // +1 Weapon
                                            {
                                                IsMagic = true,
                                                MagicModifier = 1,
                                                MagicItemRarity = MagicItemRarity.Uncommon
                                            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO         // +2 Weapon
                                            {
                                                IsMagic = true,
                                                MagicModifier = 2,
                                                MagicItemRarity = MagicItemRarity.Rare
                                            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new AdditionalWeaponPropertiesDTO     // +3 Weapon
                                            {
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.VeryRare
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO    // Vorpal Sword
                                            {
                                                Name = "Vorpal",
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "Ignores resistance to slashing damage",
                                                    "When you attack a creature that has at least one head with this weapon,\n" +
                                                    "and roll a 20 on the attack roll, you cut off one of the creature's heads.\n" +
                                                    "A creature is immune to this effect if it is immune to slashing damage,\n" +
                                                    "doesn't have or need a head, has legendary actions, or the DM decides that\n" +
                                                    "the creature is too big for it's head to be cut off with this weapon.\n" +
                                                    "Such a creature instead takes an extra 6d8 slashing damage from the hit"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Greatsword,
                                                    WeaponType.Longsword,
                                                    WeaponType.Scimitar
                                                }
                                            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO     // Weapon of Warning
                                            {
                                                Name = "of Warning",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Uncommon,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "While this weapon is on your person, you have advantage on initiative rolls.",
                                                    "You and your companions within 30 feet of you cannot be surprised,\n" +
                                                    "except when incapacitated by something other than magical sleep",
                                                    "This weapon magically awakens you and your companions within 30 feet\n" +
                                                    "if any of you are sleeping naturally when combat begins."
                                                }
                                            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO         // Vicious Weapon
                                            {
                                                Name = "Vicious",
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Rare,
                                                MagicProperties = new List<string>
                                                {
                                                    "When you roll a 20 on your attack roll with this magic weapon,\n" +
                                                    "the target takes an extra 7 damage of the weapon's type"
                                                }
                                            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO     // Trident of Fish Command
                                            {
                                                Name = "of Fish Command",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Uncommon,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "This Magic Trident Has 3 Charges",
                                                    "It Recharges 1d3 expended charges at dawn",
                                                    "While you carry it, you can use an action and expend 1 charge\n" +
                                                    "to cast dominate beast (save DC 15) from it on a beast that\n" +
                                                    "has an innate swimming speed."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Trident
                                                }
                                            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Wounding
                                            {
                                                Name = "of Wounding",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Uncommon,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "HP lost to this weapon's damage can be regained only through a\n" +
                                                    "short or long rest, rather than by regeneration, magic, or any \n" +
                                                    "other means.",
                                                    "Once per turn, when you hit a creature with an attack using this\n" +
                                                    "magic weapon, you can wound the target.",
                                                    "At the start of each of the wounded creature's turns, it takes 1d4\n" +
                                                    "necrotic damage for each time you've wounded it, and it can then make\n" +
                                                    "a DC 15 Con saving throw, ending the effect of all such wounds on\n" +
                                                    "itself on a success.",
                                                    "Alternatively, the wounded creature, or a creature within 5ft of it,\n" +
                                                    "can use an action to make a DC 15 Wis(Medicine) check, ending the\n" +
                                                    "effect of such wounds on it on a success."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Greatsword,
                                                    WeaponType.Longsword,
                                                    WeaponType.Rapier,
                                                    WeaponType.Scimitar,
                                                    WeaponType.Shortsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Vengeance
                                            {
                                                Name = "of Vengeance",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Uncommon,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "HP lost to this weapon's damage can be regained only through a\n" +
                                                    "short or long rest, rather than by regeneration, magic, or any \n" +
                                                    "other means.",
                                                    "Once per turn, when you hit a creature with an attack using this\n" +
                                                    "magic weapon, you can wound the target.",
                                                    "At the start of each of the wounded creature's turns, it takes 1d4\n" +
                                                    "necrotic damage for each time you've wounded it, and it can then make\n" +
                                                    "a DC 15 Con saving throw, ending the effect of all such wounds on\n" +
                                                    "itself on a success.",
                                                    "Alternatively, the wounded creature, or a creature within 5ft of it,\n" +
                                                    "can use an action to make a DC 15 Wis(Medicine) check, ending the\n" +
                                                    "effect of such wounds on it on a success."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Greatsword,
                                                    WeaponType.Longsword,
                                                    WeaponType.Rapier,
                                                    WeaponType.Scimitar,
                                                    WeaponType.Shortsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Sharpness
                                            {
                                                Name = "of Sharpness",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.VeryRare,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "When you attack an object with this magic sword and hit,\n" +
                                                    "maximize your weapon damage dice against the target.",
                                                    "When you attack a creature with this weapon and roll a 20\n" + 
                                                    "on the attack roll, the target takes an extra 14 slashing\n" + 
                                                    "damage. Then roll another D20. If you roll a 20,\n" + 
                                                    "you lop off one of the target's limbs, with the effect of\n" + 
                                                    "such loss determined by the DM. If the creature has no limb\n" +
                                                    "to sever, you lop off a portion of it's body instead.",
                                                    "You can speak the sword's command word to cause the blade to shed\n" +
                                                    "bright light for an additional 10 feet.\n" +
                                                    "Speaking the command word or sheathing the blade puts out the light."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Greatsword,
                                                    WeaponType.Longsword,
                                                    WeaponType.Scimitar
                                                }
                                            }),
        };
    }
}
