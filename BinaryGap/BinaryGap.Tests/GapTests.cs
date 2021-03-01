using BinaryGap.Domain;
using Xunit;

namespace BinaryGap.Tests
{
    public class GapTests
    {      
        [Fact]
        public void When_the_value_is_147_the_same_should_return_2()
        {
            int value = 147;
            const int ExpectedGap = 2;

            var result = new Gap().FindsTheBinaryGap(value);

            Assert.Equal(ExpectedGap, result);
        }

        [Fact]
        public void When_the_value_is_483_the_same_should_return_3()
        {
            int value = 483;
            const int ExpectedGap = 3;

            var result = new Gap().FindsTheBinaryGap(value);

            Assert.Equal(ExpectedGap, result);
        }

        [Fact]
        public void When_the_value_is_647_the_same_should_return_4()
        {
            int value = 647;
            const int ExpectedGap = 4;

            var result = new Gap().FindsTheBinaryGap(value);

            Assert.Equal(ExpectedGap, result);
        }

        [Fact]
        public void When_the_value_is_15_the_same_should_return_0()
        {
            int value = 15;
            const int ExpectedGap = 0;

            var result = new Gap().FindsTheBinaryGap(value);

            Assert.Equal(ExpectedGap, result);
        }

        [Fact]
        public void When_the_value_is_32_the_same_should_return_0()
        {
            int value = 32;
            const int ExpectedGap = 0;

            var result = new Gap().FindsTheBinaryGap(value);

            Assert.Equal(ExpectedGap, result);
        }
    }
}
