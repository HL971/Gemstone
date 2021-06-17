using Gemstone.Classes.DTO;
using Gemstone.Classes.Helper;
using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Classes.Logic
{
    public static class WeaponGenerator
    {
        internal static List<WeaponType> AllWeapons => HelperFunctions.GetAllEnumValues<WeaponType>().ToList();

        /// <summary>
        /// Swords that cause Slashing Damage
        /// </summary>
        internal static List<WeaponType> VorpalWeapons => new List<WeaponType>
                                                        {
                                                            WeaponType.Greatsword,
                                                            WeaponType.Longsword,
                                                            WeaponType.Scimitar
                                                        };

        public static Weapon GetRandomWeapon()
        {
            return new Weapon(ValueGenerator.GetRandomWeaponType(AllWeapons));
        }
    }
}
