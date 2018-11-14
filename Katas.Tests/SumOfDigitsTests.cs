using FluentAssertions;
using Katas.Challenges;
using Xunit;

namespace Katas.Tests
{
    public class SumOfDigitsTests
    {
        [Fact]
        public void DigitalRoot_SmallNumber_ShouldReturnCorrectValue()
        {
            //arrange
            var input = 16;

            //act
            var result = SumOfDigits.DigitalRoot(input);

            //assert
            result.Should().Be(7);
        }

        [Fact]
        public void DigitalRoot_ThreeDigitNumber_ShouldReturnCorrectValue()
        {
            //arrange
            var input = 942;

            //act
            var result = SumOfDigits.DigitalRoot(input);

            //assert
            result.Should().Be(6);
        }

        [Fact]
        public void DigitalRoot_OverHundredThousandNumber_ShouldReturnCorrectValue()
        {
            //arrange
            var input = 132189;

            //act
            var result = SumOfDigits.DigitalRoot(input);

            //assert
            result.Should().Be(6);
        }

        [Fact]
        public void DigitalRoot_HalfMillion_ShouldReturnCorrectValue()
        {
            //arrange
            var input = 493193;

            //act
            var result = SumOfDigits.DigitalRoot(input);

            //assert
            result.Should().Be(2);
        }
    }
}
