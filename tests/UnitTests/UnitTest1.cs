using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("cat","tac")]
        [InlineData("dotnet","tentod")]
        [InlineData("northwest","tsewhtron")]
        public void WorkOfReverse(String str1, String str2)
        {
            Assert.Equal(str1, ReverseString(str2));
        }

        public String ReverseString(string myStr)
        {
            String reverse = "";
            for(int i = myStr.Length - 1; i >= 0; i--)
            {
                reverse = reverse + myStr[i];
            }
            return reverse;
        }
        [Fact]
        public void checkingReverse()
        {
            String exp = "reverse";
            string str = "esrever";
            String result = ReverseString(str);
            Assert.Equal(exp, result);
        }


        [Theory]
        [InlineData(1,1)]
        [InlineData(4,2)]
        [InlineData(9,3)]
        public void squareOfNum(int i1,int i2)
        {
            Assert.Equal(i1, square(i2));
        }

        public int square(int i)
        {
            return i * i;
        }
        [Fact]
        public void checkingSquare()
        {
            int exp = 64;
            int value = 8;
            int result = square(value);
            Assert.Equal(exp, result);
        }

    }
}
