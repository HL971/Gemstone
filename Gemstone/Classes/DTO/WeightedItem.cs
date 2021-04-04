using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Classes.DTO
{
    internal class WeightedItem
    {
        internal int Weight { get; }
        internal object Value { get; }

        internal WeightedItem(int weight, object value)
        {
            Weight = weight;
            Value = value;
        }
    }
}
