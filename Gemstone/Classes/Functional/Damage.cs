using Gemstone.Definitions.Enums;

namespace Gemstone.Classes.Functional
{
    public class Damage
    {
        public int Total { get; private set; }
        public DamageType Type { get; private set; }
        public bool IsMagic { get; private set; }

        public Damage(int total, DamageType type, bool isMagic)
        {
            Total = total;
            Type = type;
            IsMagic = isMagic;
        }
    }
}
