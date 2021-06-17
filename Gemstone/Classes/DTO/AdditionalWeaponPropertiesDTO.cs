using Gemstone.Classes.Functional;
using Gemstone.Definitions.Enums;
using System.Collections.Generic;

namespace Gemstone.Classes.DTO
{
    public class AdditionalWeaponPropertiesDTO
    {
        /// <summary>
        /// Is the base weapon dice magic
        /// </summary>
        public bool IsMagic { get; set; }
        /// <summary>
        /// I.E. +1 Longsword
        /// </summary>
        public int MagicModifier { get; set; }
        public ObjectMaterials Material { get; set; }
        public List<DamageDice> AdditionalDamage { get; set; } = new List<DamageDice>();
        public List<MagicWeaponProperty> MagicProperties { get; set; } = new List<MagicWeaponProperty>();
    }
}
