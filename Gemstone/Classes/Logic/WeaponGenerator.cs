using Gemstone.Classes.DTO;
using Gemstone.Classes.Helper;
using Gemstone.Definitions.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Gemstone.Classes.Logic
{
    public static class WeaponGenerator
    {
        internal static List<WeaponType> AllWeapons => HelperFunctions.GetAllEnumValues<WeaponType>().ToList();

        public static Weapon GetRandomBasicWeapon()
        {
            return new Weapon(ValueGenerator.GetRandomWeaponType(AllWeapons));
        }

        public static Weapon GetCompletelyRandomWeapon()
        {
            if (RandomNumberGenerator.NextDouble() < 0.05)
            {
                var weaponDto = ValueGenerator.GetRandomMagicWeaponDTO();
                var type = weaponDto.RestrictedToTypes.Count > 0
                    ? ValueGenerator.GetRandomWeaponType(weaponDto.RestrictedToTypes)
                    : ValueGenerator.GetRandomWeaponType(AllWeapons);
                return new Weapon(type, weaponDto);
            }
            else
            {
                return GetRandomBasicWeapon();
            }
        }
    }
}