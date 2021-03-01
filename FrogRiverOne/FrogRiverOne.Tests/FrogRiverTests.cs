using FrogRiverOne.Domain;
using Xunit;

namespace FrogRiverOne.Tests
{
    public class FrogRiverTests
    {
        [Fact]
        public void Array_with_two_positions_and_with_time_equals_two_returns_the_earlist_positionTime()
        {
            int[] array = new int[] {1,2};
            int time = 2, earlistPosition = 1;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        }

        [Fact]
        public void Array_with_four_positions_and_with_time_equals_tree_returns_the_earlist_positionTime()
        {
            int[] array = new int[] {1,2,3,3};
            int time = 3, earlistPosition = 2;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        }

        [Fact]
        public void Array_with_four_positions_and_with_time_equals_five_returns_one_minus()
        {
            int[] array = new int[] {1,2,3,4};
            int time = 5, earlistPosition = -1;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        }

        [Fact]
        public void Array_with_eight_positions_and_with_time_equals_five_returns_the_earlist_positionTime()
        {
            int[] array = new int[] {1,3,1,4,2,3,5,4};
            int time = 5, earlistPosition = 6;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        } 

        [Fact]
        public void Array_with_one_hundred_thousand_positions_and_with_time_twenty_two_returns_the_earlist_positionTime()
        {
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            array[87345] = 22;
            array[21] = 637;

            int time = 22, earlistPosition = 87345;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        }

        [Fact]
        public void Array_with_five_positions_and_with_time_two_returns_the_earlist_positionTime()
        {
            int[] array = new int[] {2,2,2,2,2};
            int time = 2, earlistPosition = -1;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        }

        [Fact]
        public void Array_with_one_positions_and_with_time_one_returns_the_earlist_positionTime()
        {
            int[] array = new int[] {1};
            int time = 1, earlistPosition = 0;

            Assert.Equal(earlistPosition, FrogRiver.FindsEarlistPosition(time, array));
        }
    }
}
