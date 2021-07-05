using Gemstone.Classes.Functional;
using Gemstone.Definitions.Enums;
using System.Collections.Generic;

namespace Gemstone.Classes.DTO
{
    public class AdditionalWeaponPropertiesDTO
    {
        /// <summary>
        /// Not Empty if the property is restricted to certain weapons
        /// </summary>
        public List<WeaponType> RestrictedToTypes { get; set; } = new List<WeaponType>();
        public string Name { get; set; }
        public bool NamePostfix { get; set; }
        public MagicItemRarity MagicItemRarity { get; set; }
        /// <summary>
        /// Is the base weapon dice magic
        /// </summary>
        public bool IsMagic { get; set; }
        public bool RequiresAttunement { get; set; }
        public bool IsSentient { get; set; }
        /// <summary>
        /// I.E. +1 Longsword
        /// </summary>
        public int MagicModifier { get; set; }
        public ObjectMaterials Material { get; set; }
        public List<DamageDice> AdditionalDamage { get; set; } = new List<DamageDice>();
        public List<string> MagicProperties { get; set; } = new List<string>();
    }
}
