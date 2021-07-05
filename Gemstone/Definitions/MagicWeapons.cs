using Gemstone.Classes.DTO;
using Gemstone.Classes.Functional;
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
        // TODO: Holy Avenger - Attunement only by class

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
            //new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Vengeance
            //                                {
            //                                    Name = "of Vengeance",
            //                                    NamePostfix = true,
            //                                    IsMagic = true,
            //                                    MagicItemRarity = MagicItemRarity.Uncommon,
            //                                    RequiresAttunement = true,
            //                                    MagicProperties = new List<string>
            //                                    {
            //                                        "txt"
            //                                    },
            //                                    RestrictedToTypes = new List<WeaponType>
            //                                    {
            //                                        WeaponType.Greatsword,
            //                                        WeaponType.Longsword,
            //                                        WeaponType.Rapier,
            //                                        WeaponType.Scimitar,
            //                                        WeaponType.Shortsword
            //                                    }
            //                                }),
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
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Life Stealing
                                            {
                                                Name = "of Life Stealing",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Rare,
                                                RequiresAttunement = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "When you attack a creature with this magic weapon and\n" +
                                                    "roll a 20 on the attack roll, that target takes an\n" +
                                                    "extra 10 necrotic damage if it isn't a construct or\n" +
                                                    "an undead. You also gain 10 temporary hit points."
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
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Back Talker",
                                                Alignment = new Alignment(LawChaos.Chaotic, GoodEvil.Evil),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Jet affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Answerer",
                                                Alignment = new Alignment(LawChaos.Chaotic, GoodEvil.Good),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Emerald affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Concluder",
                                                Alignment = new Alignment(LawChaos.Lawful, GoodEvil.Neutral),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Amethyst affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Last Quip",
                                                Alignment = new Alignment(LawChaos.Chaotic, GoodEvil.Neutral),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Tourmaline affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Rebutter",
                                                Alignment = new Alignment(LawChaos.Neutral, GoodEvil.Good),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Topaz affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Replier",
                                                Alignment = new Alignment(LawChaos.Neutral, GoodEvil.Neutral),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Peridot affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Retorter",
                                                Alignment = new Alignment(LawChaos.Lawful, GoodEvil.Good),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Aquamarine affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Scather",
                                                Alignment = new Alignment(LawChaos.Lawful, GoodEvil.Evil),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Garnet affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO     // Sword of Answering
                                            {
                                                Name = "Squelcher",
                                                Alignment = new Alignment(LawChaos.Neutral, GoodEvil.Evil),
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicModifier = 3,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                RequiresAttunement = true,
                                                AttunementRequiresMatchingAlignment = true,
                                                MagicProperties = new List<string>
                                                {
                                                    "One of nine legendary swords. Each is modeled after\n" +
                                                    "The Legendary sword Fragarach, or \"Final Word\".",
                                                    "While you hold this sword, you can use your reaction\n" +
                                                    "to make a single melee attack against a creature that\n" +
                                                    "has dealt damage to you. You have advantage on this\n" +
                                                    "attack roll, and any damage dealt ignores any damage\n" +
                                                    "immunity or resistance the target has."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Spinel affixed to pommel"
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO     // Sun Blade
                                            {
                                                Name = "Sun Blade",
                                                ReplaceName = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Rare,
                                                MagicModifier = 2,
                                                RequiresAttunement = true,
                                                AdditionalProperties = new List<WeaponProperty>
                                                {
                                                    new WeaponProperty(WeaponPropertyType.Finesse)
                                                },
                                                ReplaceBaseDamageType = true,
                                                ReplacementDamageType = DamageType.Radiant,
                                                MagicProperties = new List<string>
                                                {
                                                    "While grasping this hilt, you can use a bonus action\n" +
                                                    "to cause a blade of pure radiance to spring into\n" +
                                                    "existance, or make the blade disappear.",
                                                    "While the blade exists, this magic longsword has\n" +
                                                    "the finesse property (Noted in profile).",
                                                    "You are proficient with this weapon if you are\n" +
                                                    "proficient with shortswords or longswords.",
                                                    "This weapon deals radiant damage instead of slashing.\n" +
                                                    "(Noted in profile)",
                                                    "If you hit an undead creature with this weapon, it\n" +
                                                    "takes an additional 1d8 radiant damage.",
                                                    "The blade of this weapon emits bright light in a\n" +
                                                    "15 foot radius, and dim light for a further 15 feet.",
                                                    "This light is sunlight.",
                                                    "While the blade persists, you can use an action to\n" +
                                                    "expand or reduce it's radius of bright and dim light\n" +
                                                    "by 5 feet each, to a maximum of 30 feet each, or to\n" +
                                                    "a minumum of 10 feet each."
                                                },
                                                ExternalDescription = new List<string>
                                                {
                                                    "Appears to just be a longsword hilt."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longsword
                                                }
                                            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new AdditionalWeaponPropertiesDTO         // Scimitar of Speed
                                            {
                                                Name = "of Speed",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                RequiresAttunement = true,
                                                MagicModifier = 2,
                                                MagicItemRarity = MagicItemRarity.VeryRare,
                                                MagicProperties = new List<string>
                                                {
                                                    "You can make one attack with this weapon as a\n" +
                                                    "bonus action on each of your turns."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Scimitar
                                                }
                                            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new AdditionalWeaponPropertiesDTO         // Oathbow
                                            {
                                                Name = "Oathbow",
                                                ReplaceName = true,
                                                RequiresAttunement = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.VeryRare,
                                                MagicProperties = new List<string>
                                                {
                                                    "When you nock an arrow on this bow, it whispers\n" +
                                                    "in Elvish, \"Swift defeat to my enemies.\"",
                                                    "When you use this weapon to make a ranged attack,\n" +
                                                    "you can, as a command phrase, say \"Swift death\n" +
                                                    "to you who have wronged me.\"",
                                                    "The target of your attack becomes your sworn enemy\n" +
                                                    "until it dies, or dawn seven days later. You can\n" +
                                                    "only have one such sworn enemy at a time. When\n" +
                                                    "your sworn enemy dies, you may choose a new one\n" +
                                                    "after the next dawn",
                                                    "When you make a ranged attack roll with this weapon\n" +
                                                    "against your sworn enemy, you have advantage on the\n" +
                                                    "roll. In addition, your target gains no benefit from\n" +
                                                    "cover, other than total cover, and you suffer no\n" +
                                                    "disadvantage due to long range.",
                                                    "If the attack hits, your sworn enemy takes an extra\n" +
                                                    "3d6 piercing damage.",
                                                    "While your sworn enemy lives, you have disadvantage on\n" +
                                                    "attack rolls with all other weapons."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Longbow
                                                }
                                            }),
            new WeightedItem(StaticIntegers.VeryRareRarityWeight, new AdditionalWeaponPropertiesDTO         // Nine Lives Stealer
                                            {
                                                Name = "Nine Lives Stealer",
                                                ReplaceName = true,
                                                RequiresAttunement = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.VeryRare,
                                                MagicModifier = 2,
                                                MagicProperties = new List<string>
                                                {
                                                    "This sword has 1d8 + 1 charges.",
                                                    "If you score a critical hit against a creature\n" +
                                                    "that has fewer than 100 HP, it must succeed on\n" +
                                                    "a DC 15 Con saving throw or be slain instantly\n" +
                                                    "as the sword tears it's life force from it's\n" +
                                                    "body (a construct or an undead is immune).\n" +
                                                    "The sword loses 1 charge if the creature is slain.\n" +
                                                    "The sword loses this property if it has no charges\n" +
                                                    "remaining."
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
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO         // Mace of Terror
                                            {
                                                Name = "of Terror",
                                                NamePostfix = true,
                                                RequiresAttunement = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Rare,
                                                MagicProperties = new List<string>
                                                {
                                                    "This mace has 3 charges.",
                                                    "The mace regains 1d3 expended charges daily ad dawn",
                                                    "While holding it, you may use an action and expend\n" +
                                                    "1 charge to release a wave of terror.",
                                                    "Each creature of your choice in a 30-foot radius\n" +
                                                    "extending from you must succeed on a DC 15 Wis\n" +
                                                    "saving throw or become frightened of you for 1 minute.",
                                                    "While it is frightened in this way, a creature must\n" +
                                                    "spend it's turn trying to move as far away from you\n" +
                                                    "as it can, and it cannot willing move to a space within\n" +
                                                    "30 feet of you. It also cannot take reactions.",
                                                    "For it's action, it can only use the Dash action or try\n" +
                                                    "to escape from an effect that prevents it from moving.",
                                                    "If it has nowhere to move, it may use the Dodge action.",
                                                    "At the end of each of it's turns, a creature may repeat\n" +
                                                    "the saving throw, ending the effect on itself on a success."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Mace
                                                }
                                            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO         // Mace of Smiting
                                            {
                                                Name = "of Smiting",
                                                NamePostfix = true,
                                                MagicModifier = 1,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Rare,
                                                MagicProperties = new List<string>
                                                {
                                                    "This mace's +1 bonus increases to +3 when you\n" +
                                                    "use the mace to attack a construct.",
                                                    "When you roll a 20 on an attack roll made with\n" +
                                                    "this weapon, the target takes an extra 7 bludgeoning\n" +
                                                    "damage, or 14 bludgeoning damage if it's a construct.",
                                                    "If a construct has 25 hit points or fewer after taking\n" +
                                                    "this damage, it is destroyed."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Mace
                                                }
                                            }),
            new WeightedItem(StaticIntegers.RareRarityWeight, new AdditionalWeaponPropertiesDTO         // Mace of Disruption
                                            {
                                                Name = "of Disruption",
                                                NamePostfix = true,
                                                RequiresAttunement = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Rare,
                                                MagicProperties = new List<string>
                                                {
                                                    "When you hit a fiend or undead with this magic\n" +
                                                    "mace, that creature takes an extra 2d6 radiant damage.",
                                                    "If the target has 25 hit points or fewer after taking\n" +
                                                    "this damage, it must succeed on a DC 15 Wis saving\n" +
                                                    "throw or be destroyed. On a successful save, the\n" +
                                                    "creature becomes frightened of you until the end of your\n" +
                                                    "next turn.",
                                                    "While you hold this weapon, it sheds bright light in a\n" +
                                                    "20 foot radius, and dim light for a further 20 feet."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Mace
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO         // Luck Blade
                                            {
                                                Name = "Luck Blade",
                                                ReplaceName = true,
                                                RequiresAttunement = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                MagicModifier = 1,
                                                MagicProperties = new List<string>
                                                {
                                                    "While this sword is on your person, you gain a\n" +
                                                    "+1 bonus to all saving throws.",
                                                    "LUCK: If this sword is on your person, you can call\n" +
                                                    "on it's luck (No action required) to reroll one attack\n" +
                                                    "roll, ability check, or saving throw you dislike. You\n" +
                                                    "must use the second roll. This property cannot be used\n" +
                                                    "again until the next dawn.",
                                                    "WISH: The sword has 1d4-1 charges. While holding it,\n" +
                                                    "you can use an action to expend 1 charge and cast the\n" +
                                                    "wish spell from it. You cannot use this property again\n" +
                                                    "until the next dawn. The sword loses this property\n" +
                                                    "if it has no charges remaining."
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
            new WeightedItem(StaticIntegers.UncommonRarityWeight, new AdditionalWeaponPropertiesDTO         // Javelin of Lightning
                                            {
                                                Name = "of Lightning",
                                                NamePostfix = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Uncommon,
                                                MagicProperties = new List<string>
                                                {
                                                    "When you hurl this Javelin and speak it's command\n" +
                                                    "word, it transforms into a bolt of lightning,\n" +
                                                    "forming a line 5 feet wide that extends out from you\n" +
                                                    "to a target within 120 feet. Each creature in the line\n" +
                                                    "excluding you and the target must make a DC 13 Dex\n" +
                                                    "saving throw, taking 4d6 lightning damage on a failed\n" +
                                                    "save, and half as much damage on a successful one.",
                                                    "The lightning bolt turns back into a javelin when it\n" +
                                                    "reaches the target. Make a ranged weapon attack against\n" +
                                                    "the target. On a hit, the target takes damage from the\n" +
                                                    "javelin plus 4d6 lightning damage.",
                                                    "This property cannot be used again until the next dawn."
                                                },
                                                RestrictedToTypes = new List<WeaponType>
                                                {
                                                    WeaponType.Javelin
                                                }
                                            }),
            new WeightedItem(StaticIntegers.LegendaryRarityWeight, new AdditionalWeaponPropertiesDTO         // Luck Blade
                                            {
                                                Name = "Luck Blade",
                                                ReplaceName = true,
                                                RequiresAttunement = true,
                                                IsMagic = true,
                                                MagicItemRarity = MagicItemRarity.Legendary,
                                                MagicModifier = 1,
                                                MagicProperties = new List<string>
                                                {
                                                    "While this sword is on your person, you gain a\n" +
                                                    "+1 bonus to all saving throws.",
                                                    "LUCK: If this sword is on your person, you can call\n" +
                                                    "on it's luck (No action required) to reroll one attack\n" +
                                                    "roll, ability check, or saving throw you dislike. You\n" +
                                                    "must use the second roll. This property cannot be used\n" +
                                                    "again until the next dawn.",
                                                    "WISH: The sword has 1d4-1 charges. While holding it,\n" +
                                                    "you can use an action to expend 1 charge and cast the\n" +
                                                    "wish spell from it. You cannot use this property again\n" +
                                                    "until the next dawn. The sword loses this property\n" +
                                                    "if it has no charges remaining."
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
        };
    }
}
