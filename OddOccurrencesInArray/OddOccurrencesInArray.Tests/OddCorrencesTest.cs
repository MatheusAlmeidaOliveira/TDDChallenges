using OddOccurrencesInArray.Domain;
using Xunit;

namespace OddOccurrencesInArray.Tests
{
    public class OddCorrencesTest
    {
        [Fact]
        public void Array_with_one_element_returns_that_element()
        {
           int[] elements = new int[] {0};
           const int unpaired = 0;
           
           Assert.Equal(unpaired, OddCorrences.FindsUnpairedElement(elements));
        }

        [Fact]
        public void Array_with_three_elements_returns_the_unpaired_element()
        {
            int[] elements = new int[] {1,2,1};
            const int unpaired = 2;

            Assert.Equal(unpaired, OddCorrences.FindsUnpairedElement(elements));
        }

        [Fact]
        public void Array_with_five_elements_returns_the_unpaired_element()
        {
            int[] elements = new int[] {1,1,1,2,2};
            const int unpaired = 1;

            Assert.Equal(unpaired, OddCorrences.FindsUnpairedElement(elements));
        }

        [Fact]
        public void Array_with_one_million_elements_returns_the_unpaired_element()
        {
            int[] elements = new int[1000000];
            const int unpaired = 2;

            elements[0] = 2;
            for (int i = 1; i < elements.Length; i++)
            {
                elements[i] = 1;
            }

            Assert.Equal(unpaired, OddCorrences.FindsUnpairedElement(elements));
        }
    }
}
