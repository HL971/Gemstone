using System;

namespace Gemstone.Classes.Helper
{
    /// <summary>
    /// One Random Number Generator used by all classes
    /// </summary>
    internal static class RandomNumberGenerator
    {
        private static readonly Random rng = new Random();

        internal static double NextDouble()
        {
            return rng.NextDouble();
        }

        internal static int Next(int max)
        {
            return rng.Next(max);
        }
    }
}