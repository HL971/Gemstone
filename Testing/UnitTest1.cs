using FluentAssertions;
using Gemstone.Classes.DTO;
using System;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double value = 0;

            for(int x = 0; x < 50000; x++)
            {
                var gem = new Gem();
                value += gem.Value;
            }

            value /= 50000;

            value.Should().BeGreaterThan(0.0);
        }
    }
}
