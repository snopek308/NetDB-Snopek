using System;
using Xunit;

namespace YourName.UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void MathHelper_AddNumbers_Success()
        {
            // arrange
            MathHelper main = new MathHelper();

            // act
            var result = main.AddNumbers(1, 2);

            // assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void MathHelper_AddNumbers_Failure()
        {
            // arrange
            MathHelper main = new MathHelper();

            // act
            var result = main.AddNumbers(1, 2);

            // assert
            Assert.Equal(0, result);
        }
    }
}
