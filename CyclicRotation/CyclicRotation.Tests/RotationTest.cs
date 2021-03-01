using CyclicRotation.Domain;
using Xunit;

namespace CyclicRotation.Tests
{
    public class RotationTest
    {
        [Fact]
        public void When_the_array_is_composed_of_3_8_9_7_6_and_times_of_3_the_same_should_return_9_7_6_3_8()
        {
            int[]array = new int[] {3, 8, 9, 7, 6};
            int[]arrayResult = new int[] {9, 7, 6, 3, 8};
            int times = 3;

            var rotation = new Rotation();

            var result = rotation.RotatesTheArray(array, times);

            Assert.Equal(result, arrayResult);
        }

        [Fact]
        public void When_the_array_is_composed_of_0_0_0_and_times_of_1_the_same_should_return_0_0_0()
        {
            int[]array = new int[] {0, 0, 0};
            int[]arrayResult = new int[] {0, 0, 0};
            int times = 1;

            var rotation = new Rotation();

            var result = rotation.RotatesTheArray(array, times);

            Assert.Equal(result, arrayResult);
        }

        [Fact]
        public void When_the_array_is_composed_of_1_2_3_4_and_times_of_4_the_same_should_return_1_2_3_4()
        {
            int[]array = new int[] {1, 2, 3, 4};
            int[]arrayResult = new int[] {1, 2, 3, 4};
            int times = 4;

            var rotation = new Rotation();

            var result = rotation.RotatesTheArray(array, times);

            Assert.Equal(result, arrayResult);
        }
    }
}
