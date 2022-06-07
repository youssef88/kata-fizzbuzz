using System;
using Xunit;

namespace fizzbuzz.unitTests
{
    public class FizzBuzzShould
    {
        
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("4", 4)]
        public void Convert_number_to_FizzBuzz_string(string expectedOutput, int input )
        {
            Assert.Equal(expectedOutput, FizzBuzz.Convert(input));
        }


        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(27)]
        public void Convert_multiple_of_3_to_FizzBuzz_string(int input)
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(input));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        [InlineData(55)]
        public void Convert_multiple_of_5_to_FizzBuzz_string(int input)
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(input));

        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        public void Convert_multiple_of_3_and_5_to_FizzBuzz_string(int input)
        {
            Assert.Equal("FizzBuzz", FizzBuzz.Convert(input));

        }
    }
}
