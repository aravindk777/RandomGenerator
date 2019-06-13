using Randomizer.Core.RuleEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.RuleEngineTests
{
    public class RuleEngineTest
    {
        IRuleEngine engineToTest;

        public RuleEngineTest()
        {
            engineToTest = new RuleEngine();
        }

        [Theory(DisplayName = "Test for AvailableNext moves")]
        [InlineData(4, new int[] { 8, 9, 1, 7 })]
        [InlineData(2, new int[] { 3, 1, 5, 8 })]
        public void Test_For_AvailableMoves(int startingValue, int[] expectedResult)
        {
            // arrange
            int[][] data = new int[][] { new int[3] { 1, 2, 3 }, new int[3] { 7, 5, 6 }, new int[3] { 4, 8, 9 } };

            // act
            var actualResult = engineToTest.GetAvailableMoves(startingValue, data, Randomizer.Core.Models.MovingRules.Pawn);
            // assert
            Assert.Equal(4, actualResult.Length);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
