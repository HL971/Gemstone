using Gemstone.Classes.Functional;
using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Classes.DTO
{
    public class AdditionalWeaponPropertiesDTO
    {
        public bool IsMagic { get; set; }
        public ObjectMaterials Material { get; set; }
        public List<DamageDice> AdditionalDamage { get; set; }

        public AdditionalWeaponPropertiesDTO()
        {
            AdditionalDamage = new List<DamageDice>();
        }
    }
}
