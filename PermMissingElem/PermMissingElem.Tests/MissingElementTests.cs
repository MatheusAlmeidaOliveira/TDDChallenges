using Xunit;
using PermMissingElem.Domain;

namespace PermMissingElem.Tests
{
    public class MissingElementTests
    {
        [Fact]
        public void Array_of_four_elements_should_return_the_missing_element()
        {
            int[] array = new int[] {1,2,4,5};
            int missingElement = 3;
            Assert.Equal(missingElement, MissingElement.FindsMissingElement(array));
        }

        [Fact]
        public void Array_of_six_elements_should_return_the_missing_element()
        {
            int[] array = new int[] {1,2,7,5,6,3};
            int missingElement = 4;
            Assert.Equal(missingElement, MissingElement.FindsMissingElement(array));
        }

        [Fact]
        public void Array_of_eleven_elements_should_return_the_missing_element()
        {
            int[] array = new int[] {1,2,7,5,6,3,8,9,10,4,12};
            int missingElement = 11;
            Assert.Equal(missingElement, MissingElement.FindsMissingElement(array));
        }

        [Fact]
        public void Array_of_two_elements_should_return_the_missing_element()
        {
            int[] array = new int[] {1,2};
            int missingElement = 3;
            Assert.Equal(missingElement, MissingElement.FindsMissingElement(array));
        }
    }
}
