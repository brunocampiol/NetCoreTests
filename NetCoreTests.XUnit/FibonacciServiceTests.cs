﻿using NetCoreTests.App.Services;
using Xunit;

namespace NetCoreTests.XUnit
{
    public sealed class FibonacciServiceTests
    {
        [Fact]
        public void NthFibonacciNumber_WhenFirstSequenceIndex_ExpectsZero()
        {
            // Assamble
            // Act
            var actualResult = FibonacciService.NthFibonacciNumber(0);

            // Assert
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void NthFibonacciNumber_WhenSecondSequenceIndex_ExpectsOne()
        {
            // Assamble
            // Act
            var actualResult = FibonacciService.NthFibonacciNumber(1);

            // Assert
            Assert.Equal(1, actualResult);
        }

        [Fact]
        public void NthFibonacciNumber_When13SequenceIndex_Expects233()
        {
            // Assamble
            // Act
            var actualResult = FibonacciService.NthFibonacciNumber(13);

            // Assert
            Assert.Equal(233, actualResult);
        }
    }
}
