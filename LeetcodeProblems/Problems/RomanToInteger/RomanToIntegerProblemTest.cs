namespace LeetCodeTest.Problems
{
    public class RomanToIntegerProblemTest
    {
        [Theory]
        [InlineData("CXXIX", 129)]
        [InlineData("DCCVII", 707)]
        [InlineData("MMXIX", 2019)]
        [InlineData("XCIII", 93)]
        [InlineData("CMXCI", 991)]
        public void Solve_ShouldReturnCorrectIntegerNumber(string romanNumber, int expectedResult)
        {
            var result = RomanToInteger.Solve(romanNumber);
            Assert.Equal(expectedResult, result);
        }
    }
}