namespace Gemstone.Definitions.Enums
{
    public enum WeaponPropertyType
    {
        Ammunition,
        Finesse,
        Heavy,
        Light,
        Loading,
        Range,
        Reach,
        Special,
        Thrown,
        TwoHanded,
        Versatile
    }

    public static class WeaponPropertyMethods
    {
        public static string WeaponPropertyString(this WeaponPropertyType value)
        {
            switch (value)
            {
                case WeaponPropertyType.TwoHanded:
                    return "Two-Handed";
                default:
                    return value.ToString();
            }
        }
    }
}
