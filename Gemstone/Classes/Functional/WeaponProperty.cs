using Gemstone.Definitions.Enums;

namespace Gemstone.Classes.Functional
{
    public class WeaponProperty
    {
        public WeaponPropertyType Type { get; private set; }
        public int? MinRange { get; private set; }
        public int? MaxRange { get; private set; }
        public Die VersatileDie { get; private set; }

        public WeaponProperty(WeaponPropertyType type, int? minRange = null, int? maxRange = null)
        {
            Type = type;
            MinRange = minRange;
            MaxRange = maxRange;
        }

        public WeaponProperty(WeaponPropertyType type, Die versatileDie)
        {
            Type = type;
            VersatileDie = versatileDie;
        }
    }
}
