using Gemstone.Definitions.Enums;

namespace Gemstone.Classes.Functional
{
    public class DamageDice
    {
        public Die Die { get; private set; }
        public DamageType Type { get; private set; }
        public bool IsMagic { get; private set; }

        public DamageDice(Die die, DamageType type, bool isMagic)
        {
            Die = die;
            Type = type;
            IsMagic = isMagic;
        }

        public Damage RollDamage(bool isCritical = false)
        {
            return new Damage(Die.Roll(isCritical), Type, IsMagic);
        }
    }
}
