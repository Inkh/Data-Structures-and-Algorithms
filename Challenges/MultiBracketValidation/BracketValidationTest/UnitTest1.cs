using System;
using Xunit;
using static MultiBracketValidation.Program;
using StackAndQueue.Classes;

namespace BracketValidationTest
{
    public class UnitTest1
    {
        Stack myStack = new Stack(null);

        /// <summary>
        /// Tests some possible bracket combinations and edge cases.
        /// </summary>
        /// <param name="expected">True or false</param>
        /// <param name="input">String of brackets</param>
        [Theory]
        [InlineData(true, "{[()]}")]
        [InlineData(false, "{p[]}[")]
        [InlineData(true, "")]
        [InlineData(false, "{[}]")]
        [InlineData(false, "]()")]
        [InlineData(true, "alsdkjfowiehgoih")]
        [InlineData(true, "(){}[]")]
        public void WillCheckBalanceTest(bool expected, string input)
        {
            Assert.True(MultiBracketValidate(input) == expected);
        }
    }
}
