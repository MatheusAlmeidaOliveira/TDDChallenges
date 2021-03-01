using FrogJmp.Domain;
using Xunit;

namespace FrogJmp.Tests
{
    public class FrogJumpsTests
    {
        [Fact]
        public void When_the_distance_of_the_frog_to_the_target_is_one_and_its_jumps_is_one()
        {
            int currentPosition = 5, target = 6, jumpsDistance = 1;
            int minimalJumps = 1;

            Assert.Equal(minimalJumps, FrogJumps.MinimalNumberOfJumps(currentPosition, target, jumpsDistance));
        }

        [Fact]
        public void When_the_distance_of_the_frog_to_the_target_is_5_and_its_jumps_is_one()
        {
            int currentPosition = 5, target = 10, jumpsDistance = 1;
            int minimalJumps = 5;

            Assert.Equal(minimalJumps, FrogJumps.MinimalNumberOfJumps(currentPosition, target, jumpsDistance));
        }

        [Fact]
        public void When_the_distance_of_the_frog_to_the_target_is_100_and_its_jumps_is_10()
        {
            int currentPosition = 100, target = 200, jumpsDistance = 10;
            int minimalJumps = 10;

            Assert.Equal(minimalJumps, FrogJumps.MinimalNumberOfJumps(currentPosition, target, jumpsDistance));
        }

        [Fact]
        public void When_the_distance_of_the_frog_to_the_target_is_4998_and_its_jumps_is_101()
        {
            int currentPosition = 5002, target = 10000, jumpsDistance = 101;
            int minimalJumps = 50;

            Assert.Equal(minimalJumps, FrogJumps.MinimalNumberOfJumps(currentPosition, target, jumpsDistance));
        }

        [Fact] 
        public void When_the_distance_of_the_frog_to_the_target_is_999999994_and_its_jumps_is_11447()
        {
            int currentPosition = 6, target = 1000000000, jumpsDistance = 11447;
            int minimalJumps = 87360;

            Assert.Equal(minimalJumps, FrogJumps.MinimalNumberOfJumps(currentPosition, target, jumpsDistance));
        }
    }
}
