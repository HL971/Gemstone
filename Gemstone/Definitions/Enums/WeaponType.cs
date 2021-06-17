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
    }
}
