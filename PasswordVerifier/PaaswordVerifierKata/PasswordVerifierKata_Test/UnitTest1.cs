using System;
using Xunit;
using PasswordVerifierKata;


namespace PasswordVerifierKata_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("hfas", false)]
        [InlineData("ksjdafkaljasdkfj", true)]
        [InlineData("45631321023adsfa", true)]
        public void CheckLengthTest(string password, bool expected)
        {
            bool actual = PasswordVerifier.CheckLength(password);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("null", true)]
        [InlineData(" ", false)]
        public void CheckNullOrEmptyTest(string password, bool expected)
        {
            bool actual = PasswordVerifier.CheckNullOrEmpty(password);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aakdsljfSFJKSJFKF", true)]
        [InlineData("JFSLDJFSFDG", false)]
        public void CheckLowerTest(string password, bool expected)
        {
            bool actual = PasswordVerifier.CheckLower(password);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("dskajf", false)]
        [InlineData("dsLKJjf", true)]
       
        public void CheckUpperTest(string password, bool expected)
        {
            bool actual = PasswordVerifier.CheckUpper(password);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("alkdfj", false)]
        [InlineData("74198hadsfhka", true)]
        public void CheckNumberTest(string password, bool expected)
        {
            bool actual = PasswordVerifier.CheckNumber(password);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("jadslf1231As", true)]
        [InlineData("A2465JDFAL", false)]
        [InlineData("4aA", true)]
        [InlineData("3AJDKFJASFKA", false)]
        [InlineData("   ", false)]
      
        public void PasswordOkTest(string password, bool expected)
        {
            bool actual = PasswordVerifier.PasswordOk(password);
            Assert.Equal(expected, actual);
        }

    }
}
