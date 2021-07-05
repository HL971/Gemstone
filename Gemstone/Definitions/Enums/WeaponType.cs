using System;

namespace Gemstone.Definitions.Enums
{
    public enum WeaponType
    {
        Club,
        Dagger,
        Greatclub,
        Handaxe,
        Javelin,
        LightHammer,
        Mace,
        Quarterstaff,
        Sickle,
        Spear,
        LightCrossbow,
        Dart,
        Shortbow,
        Sling,
        Battleaxe,
        Flail,
        Glaive,
        Greataxe,
        Greatsword,
        Halberd,
        Lance,
        Longsword,
        Maul,
        Morningstar,
        Pike,
        Rapier,
        Scimitar,
        Shortsword,
        Trident,
        WarPick,
        Warhammer,
        Whip,
        Blowgun,
        HandCrossbow,
        HeavyCrossbow,
        Longbow,
        Net
    }

    internal static class WeaponTypeAdditions
    {
        internal static string WeaponTypeString(this WeaponType type)
        {
            switch (type)
            {
                case WeaponType.LightHammer:
                    return "Light Hammer";
                case WeaponType.LightCrossbow:
                    return "Light Crossbow";
                case WeaponType.HandCrossbow:
                    return "Hand Crossbow";
                case WeaponType.HeavyCrossbow:
                    return "Heavy Crossbow";
                default:
                    return type.ToString();
            }
        }

        internal static string WeaponClassificationString(this WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Club:
                case WeaponType.Dagger:
                case WeaponType.Greatclub:
                case WeaponType.Handaxe:
                case WeaponType.Javelin:
                case WeaponType.LightHammer:
                case WeaponType.Mace:
                case WeaponType.Quarterstaff:
                case WeaponType.Sickle:
                case WeaponType.Spear:
                    return StaticStrings.SimpleMelee;
                case WeaponType.LightCrossbow:
                case WeaponType.Dart:
                case WeaponType.Shortbow:
                case WeaponType.Sling:
                    return StaticStrings.SimpleRanged;
                case WeaponType.Battleaxe:
                case WeaponType.Flail:
                case WeaponType.Glaive:
                case WeaponType.Greataxe:
                case WeaponType.Greatsword:
                case WeaponType.Halberd:
                case WeaponType.Lance:
                case WeaponType.Longsword:
                case WeaponType.Maul:
                case WeaponType.Morningstar:
                case WeaponType.Pike:
                case WeaponType.Rapier:
                case WeaponType.Scimitar:
                case WeaponType.Shortsword:
                case WeaponType.Trident:
                case WeaponType.WarPick:
                case WeaponType.Warhammer:
                case WeaponType.Whip:
                    return StaticStrings.MartialMelee;
                case WeaponType.Blowgun:
                case WeaponType.HandCrossbow:
                case WeaponType.HeavyCrossbow:
                case WeaponType.Longbow:
                case WeaponType.Net:
                    return StaticStrings.MartialRanged;
                default:
                    throw new IndexOutOfRangeException("Error Getting Classification String: Unknown Type: " + type.WeaponTypeString());
            }
        }
    }
}
