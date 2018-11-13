using FluentAssertions;
using Katas.Challenges;
using Xunit;

namespace Katas.Tests
{
    public class SmileysCounterTests
    {
        [Fact]
        public void CountSmileys_OneValidFace_ShouldReturnCorrectNumber()
        {
            //arrange
            var input = new[] { ";]", ":[", ";*", ":$", ";-D" };
            var expected = 1;

            //act
            var result = SmileysCounter.CountSmileys(input);

            //assert
            result.Should().Be(expected);
        }

        [Fact]
        public void CountSmileys_TwoValidFaces_ShouldReturnCorrectNumber()
        {
            //arrange
            var input = new [] {":)", ";(", ";}", ":-D"};
            var expected = 2;

            //act
            var result = SmileysCounter.CountSmileys(input);

            //assert
            result.Should().Be(expected);
        }

        [Fact]
        public void CountSmileys_ThreeValidFaces_ShouldReturnCorrectNumber()
        {
            //arrange
            var input = new[] { ";D", ":-(", ":-)", ";~)" };
            var expected = 3;

            //act
            var result = SmileysCounter.CountSmileys(input);

            //assert
            result.Should().Be(expected);
        }
    }
}
