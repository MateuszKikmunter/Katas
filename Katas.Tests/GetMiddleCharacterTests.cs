using System.Linq;
using FluentAssertions;
using Katas.Challenges;
using Xunit;

namespace Katas.Tests
{
    public class GetMiddleCharacterTests
    {
        [Fact]
        public void GetMiddle_Odd_ShouldReturnCorrectString()
        {
            //arrange
            var input = "abcdefg";

            //act
            var result = GetMiddleCharacter.GetMiddle(input);

            //assert
            result.Should().Be("d");
        }

        [Fact]
        public void GetMiddle_Even_ShouldReturnCorrectString()
        {
            //arrange
            var input = "abcdef";

            //act
            var result = GetMiddleCharacter.GetMiddle(input);

            //assert
            result.Should().Be("cd");
        }
    }
}
