using System;
using Xunit;
using OddEvenProject;

namespace OddEven_TestProject
{
    public class UnitTest1
    {
       

        [Theory]
        [InlineData(1, false)]
        [InlineData(0, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(-1, false)]
        [InlineData(17, true)]
        [InlineData(42, false)]
        [InlineData(53, true)]
        [InlineData(99, false)]
        public void IsPrimeTest(int number, bool expected)
        {
            bool actual = OddEvenClass.IsPrime(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, "EVEN")]
        [InlineData(1, "ODD")]
        [InlineData(2, "PRIME")]
        [InlineData(3, "PRIME")]
        [InlineData(4, "EVEN")]
        [InlineData(10, "EVEN")]
        [InlineData(13, "PRIME")]
        [InlineData(59, "PRIME")]
        [InlineData(65, "ODD")]
        [InlineData(100, "EVEN")]

        public void PrimeEvenOrOddTest(int num, string expected)
        {
            string actual = OddEvenClass.PrimeEvenOrOdd(num);
            Assert.Equal(expected, actual);
        }



    }
}
