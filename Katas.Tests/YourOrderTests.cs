using FluentAssertions;
using Katas.Challenges;
using Xunit;

namespace Katas.Tests
{
    public class YourOrderTests
    {
        [Fact]
        public void GetOrder_EmptyString_ShouldReturnEmptyString()
        {
            //arrange
            var input = string.Empty;

            //act
            var result = YourOrder.GetOrder(input);

            //assert
            result.Should().Be(input);
        }

        [Fact]
        public void GetOrder_SimpleTest_ShouldReturnCorrectValue()
        {
            //arrange
            var input = "is2 Thi1s T4est 3a";

            //act
            var result = YourOrder.GetOrder(input);

            //assert
            result.Should().Be("Thi1s is2 3a T4est");
        }

        [Fact]
        public void GetOrder_SimpleTest1_ShouldReturnCorrectValue()
        {
            //arrange
            var input = "4of Fo1r pe6ople g3ood th5e the2";

            //act
            var result = YourOrder.GetOrder(input);

            //assert
            result.Should().Be("Fo1r the2 g3ood 4of th5e pe6ople");
        }
    }
}
