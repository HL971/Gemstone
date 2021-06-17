using Gemstone.Classes.Logic;
using System;

namespace Gemstone.Classes.Functional
{
    public class Die
    {
        public int Count { get; private set; }
        public int Size { get; private set; }

        public Die(int count, int size)
        {
            if (count < 1)
                throw new ArgumentOutOfRangeException(nameof(count), "Error: Die count must be greater than zero");

            if (size < 1)
                throw new ArgumentOutOfRangeException(nameof(size), "Error: Die size must be greater than zero");

            Count = count;
            Size = size;
        }

        public int Roll(bool isCritical = false)
        {
            return (isCritical && Size > 1)
                ? ValueGenerator.RollDice(this) + ValueGenerator.RollDice(this)
                : ValueGenerator.RollDice(this);
        }

        public override string ToString()
        {
            return Count + "d" + Size;
        }
    }
}
