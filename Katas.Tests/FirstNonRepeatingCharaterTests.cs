using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Katas.Challenges;
using Xunit;

namespace Katas.Tests
{
    public class FirstNonRepeatingCharaterTests
    {
        [Fact]
        public void GetFirstNonRepeating_EmptyString_ShouldReturnEmptyString()
        {
            //arrange
            var input = string.Empty;

            //act
            var result = FirstNonRepeatingCharater.GetFirstNonRepeating(input);

            //assert
            result.Should().BeNullOrWhiteSpace();
        }

        [Fact]
        public void GetFirstNonRepeating_AllLower_ShouldReturnEmptyString()
        {
            //arrange
            var input = "abba";

            //act
            var result = FirstNonRepeatingCharater.GetFirstNonRepeating(input);

            //assert
            result.Should().BeNullOrWhiteSpace();
        }

        [Fact]
        public void GetFirstNonRepeating_AllUpper_ShouldReturnEmptyString()
        {
            //arrange
            var input = "ABBA";

            //act
            var result = FirstNonRepeatingCharater.GetFirstNonRepeating(input);

            //assert
            result.Should().BeNullOrWhiteSpace();
        }

        [Fact]
        public void GetFirstNonRepeating_NoRepetitionsLower_ShouldReturnCorrectValue()
        {
            //arrange
            var input = "abBcC";

            //act
            var result = FirstNonRepeatingCharater.GetFirstNonRepeating(input);

            //assert
            result.Should().Be("a");
        }

        [Fact]
        public void GetFirstNonRepeating_NoRepetitionsUpper_ShouldReturnCorrectValue()
        {
            //arrange
            var input = "AbBcC";

            //act
            var result = FirstNonRepeatingCharater.GetFirstNonRepeating(input);

            //assert
            result.Should().Be("A");
        }

        [Fact]
        public void GetFirstNonRepeating_RandomString_ShouldReturnCorrectValue()
        {
            //arrange
            var input = "\\mPD}^\\Mnt_g\\{YGpAHHYSZ[LD{hIBGCFs[OXHiyMRaIJsv";

            //act
            var result = FirstNonRepeatingCharater.GetFirstNonRepeating(input);

            //assert
            result.Should().Be("}");
        }
    }
}
