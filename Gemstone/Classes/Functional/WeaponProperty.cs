using Gemstone.Definitions.Enums;

namespace Gemstone.Classes.Functional
{
    public class WeaponProperty
    {
        public WeaponPropertyType Type { get; private set; }
        public int? MinRange { get; private set; }
        public int? MaxRange { get; private set; }
        public Die VersatileDie { get; private set; }

        public WeaponProperty(WeaponPropertyType type)
        {
            Type = type;
        }

        public WeaponProperty(WeaponPropertyType type, Die versatileDie)
        {
            Type = type;
            VersatileDie = versatileDie;
        }

        public WeaponProperty(WeaponPropertyType type, int minRange, int maxRange)
        {
            Type = type;
            MinRange = minRange;
            MaxRange = maxRange;
        }

        public override string ToString()
        {
            if (MinRange.HasValue && MaxRange.HasValue)
                return Type.WeaponPropertyString() + " (range " + MinRange + "/" + MaxRange + ")";
            else if (VersatileDie != null)
                return Type.WeaponPropertyString() + "(" + VersatileDie + ")";
            else
                return Type.WeaponPropertyString();
        }
    }
}
