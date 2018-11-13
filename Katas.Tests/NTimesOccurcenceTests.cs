using FluentAssertions;
using Katas.Challenges;
using Xunit;

namespace Katas.Tests
{
    public class NTimesOccurcenceTests
    {
        [Fact]
        public void RemoveDuplicates_OneDuplicate_ShouldReturnCorrectValues()
        {
            //arrange
            var input = new int[] {20, 37, 20, 21};
            var expected = new int[] {20, 37, 21};

            //act
            var result = NTimesOccurcence.RemoveDuplicates(input, 1);

            //assert
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void RemoveDuplicates_MaxThreeDuplicates_ShouldReturnCorrectValues()
        {
            //arrange
            var input = new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 };
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            //act
            var result = NTimesOccurcence.RemoveDuplicates(input, 3);

            //assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
