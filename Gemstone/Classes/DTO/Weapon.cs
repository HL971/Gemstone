using System;
using Gemstone.Classes.Functional;
using Gemstone.Definitions.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Gemstone.Classes.DTO
{
    public class Weapon
    {
        // ----- Properties --- //
        public WeaponType Type { get; private set; }
        public int MagicModifier { get; private set; }
        public double Cost { get; private set; }
        public double Weight { get; private set; }
        public bool IsMagic { get; private set; }
        public List<DamageDice> Damage { get; private set; }
        public List<WeaponProperty> Properties { get; private set; }
        public List<MagicWeaponProperty> MagicProperties { get; private set; }
        public ObjectMaterials Material { get; private set; }

        private string WeaponTypeString => MagicProperties?.Count > 0
            ? MagicProperties.First().ToString() + " " + Type.WeaponTypeString()
            : MagicModifier != 0
                ? "+" + MagicModifier + " " + Type.WeaponTypeString()
                : Type.WeaponTypeString();

        // ----- Public Methods --- //
        public Weapon(WeaponType type, AdditionalWeaponPropertiesDTO additionalProperties = null)
        {
            Type = type;
            Damage = new List<DamageDice>();
            Properties = new List<WeaponProperty>();

            BasicWeaponSetup(additionalProperties != null ? additionalProperties.IsMagic : false);
            
            if (additionalProperties != null)
            {
                Material = additionalProperties.Material;
                MagicModifier = additionalProperties.MagicModifier;
                Damage.AddRange(additionalProperties.AdditionalDamage);
                MagicProperties.AddRange(additionalProperties.MagicProperties);
            }

            IsMagic = Damage.Any(x => x.IsMagic);
        }

        public List<Damage> RollDamage(bool isCritical = false)
        {
            var damage = new List<Damage>();

            foreach(var die in Damage)
            {
                damage.Add(die.RollDamage(isCritical));
            }

            return damage;
        }

        public List<string> PlayerDocumentStrings()
        {
            var strings = new List<string>
            {
                WeaponTypeString,
                Type.WeaponClassificationString()
            };

            if (Damage.Count > 0) // Anything but basic non-magic net
            {
                strings.Add(string.Empty);
                strings.Add(Damage.First().DamageString(MagicModifier));

                for (int x = 1; x < Damage.Count; x++)
                {
                    strings.Add(Damage[x].DamageString());
                }
            }

            if (Properties.Count > 0)
            {
                strings.Add(string.Empty);
                strings.Add("- Properties -");
                strings.Add(string.Empty);

                foreach (var property in Properties)
                    strings.Add(property.ToString());
            }

            return strings;
        }

        // ----- Private Methods --- //
        private void BasicWeaponSetup(bool isMagic)
        {
            switch (Type)
            {
                case WeaponType.Club:
                    Cost = 0.1;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    break;
                case WeaponType.Dagger:
                    Cost = 2.0;
                    Weight = 1;
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Finesse));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 20, 60));
                    break;
                case WeaponType.Greatclub:
                    Cost = 0.2;
                    Weight = 10;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Handaxe:
                    Cost = 5.0;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 20, 60));
                    break;
                case WeaponType.Javelin:
                    Cost = 0.5;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 30, 120));
                    break;
                case WeaponType.LightHammer:
                    Cost = 2.0;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 20, 60));
                    break;
                case WeaponType.Mace:
                    Cost = 5.0;
                    Weight = 4;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Bludgeoning, isMagic));
                    break;
                case WeaponType.Quarterstaff:
                    Cost = 0.2;
                    Weight = 4;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Versatile, new Die(1, 8)));
                    break;
                case WeaponType.Sickle:
                    Cost = 1.0;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    break;
                case WeaponType.Spear:
                    Cost = 1.0;
                    Weight = 3;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 20, 60));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Versatile, new Die(1, 8)));
                    break;
                case WeaponType.LightCrossbow:
                    Cost = 25.0;
                    Weight = 5;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 80, 320));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Loading));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Dart:
                    Cost = 0.05;
                    Weight = 0.25;
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Finesse));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 20, 60));
                    break;
                case WeaponType.Shortbow:
                    Cost = 25;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 80, 320));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Sling:
                    Cost = 0.1;
                    Weight = 0.0; // Yes Jason, no weight
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 30, 120));
                    break;
                case WeaponType.Battleaxe:
                    Cost = 10;
                    Weight = 4;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Versatile, new Die(1, 10)));
                    break;
                case WeaponType.Flail:
                    Cost = 10;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Bludgeoning, isMagic));
                    break;
                case WeaponType.Glaive:
                    Cost = 20;
                    Weight = 6;
                    Damage.Add(new DamageDice(new Die(1, 10), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Reach));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Greataxe:
                    Cost = 30;
                    Weight = 7;
                    Damage.Add(new DamageDice(new Die(1, 12), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Greatsword:
                    Cost = 50;
                    Weight = 6;
                    Damage.Add(new DamageDice(new Die(2, 6), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Halberd:
                    Cost = 20;
                    Weight = 6;
                    Damage.Add(new DamageDice(new Die(1, 10), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Reach));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Lance:
                    Cost = 10;
                    Weight = 6;
                    Damage.Add(new DamageDice(new Die(1, 12), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Reach));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Special));
                    break;
                case WeaponType.Longsword:
                    Cost = 15;
                    Weight = 3;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Versatile, new Die(1, 10)));
                    break;
                case WeaponType.Maul:
                    Cost = 10;
                    Weight = 10;
                    Damage.Add(new DamageDice(new Die(2, 6), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Morningstar:
                    Cost = 15;
                    Weight = 4;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Piercing, isMagic));
                    break;
                case WeaponType.Pike:
                    Cost = 5;
                    Weight = 18;
                    Damage.Add(new DamageDice(new Die(1, 10), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    break;
                case WeaponType.Rapier:
                    Cost = 25;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Finesse));
                    break;
                case WeaponType.Scimitar:
                    Cost = 25;
                    Weight = 3;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Finesse));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    break;
                case WeaponType.Shortsword:
                    Cost = 10;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Finesse));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    break;
                case WeaponType.Trident:
                    Cost = 5;
                    Weight = 4;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 20, 60));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Versatile, new Die(1, 8)));
                    break;
                case WeaponType.WarPick:
                    Cost = 5;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Piercing, isMagic));
                    break;
                case WeaponType.Warhammer:
                    Cost = 15;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Bludgeoning, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Versatile, new Die(1, 10)));
                    break;
                case WeaponType.Whip:
                    Cost = 2;
                    Weight = 3;
                    Damage.Add(new DamageDice(new Die(1, 4), DamageType.Slashing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Finesse));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Reach));
                    break;
                case WeaponType.Blowgun:
                    Cost = 10;
                    Weight = 1;
                    Damage.Add(new DamageDice(new Die(1, 1), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 25, 100));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Loading));
                    break;
                case WeaponType.HandCrossbow:
                    Cost = 75;
                    Weight = 3;
                    Damage.Add(new DamageDice(new Die(1, 6), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 30, 120));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Light));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Loading));
                    break;
                case WeaponType.HeavyCrossbow:
                    Cost = 50;
                    Weight = 18;
                    Damage.Add(new DamageDice(new Die(1, 10), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 100, 400));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Loading));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Longbow:
                    Cost = 50;
                    Weight = 2;
                    Damage.Add(new DamageDice(new Die(1, 8), DamageType.Piercing, isMagic));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Ammunition, 150, 600));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Heavy));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.TwoHanded));
                    break;
                case WeaponType.Net:
                    Cost = 1;
                    Weight = 3;
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Special));
                    Properties.Add(new WeaponProperty(WeaponPropertyType.Thrown, 5, 15));
                    break;
                default:
                    throw new InvalidOperationException("Error: Weapon Type has not been properly set up");
            }
        }
    }
}
