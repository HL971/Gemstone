using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Classes.DTO
{
    public class Potion
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public List<string> Description { get; set; } = new List<string>();
        public MagicItemRarity Rarity { get; set; }

        public override string ToString()
        {
            return "Potion of " + Name;
        }
    }
}
