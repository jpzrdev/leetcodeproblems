namespace LeetCodeTest.Problems
{
    public class PalindromeNumberTest
    {
        [Theory]
        [InlineData(123321)]
        [InlineData(1112111)]
        [InlineData(2222)]
        public void Solve_ShouldReturnTrue_WhenNumberIsPalindrome(int number)
        {
            var result = PalindromeNumber.Solve(number);
            Assert.True(result);
        }

        [Theory]
        [InlineData(1234)]
        [InlineData(111211)]
        [InlineData(1313)]
        public void Solve_ShouldReturnFalse_WhenNumberIsNotPalindrome(int number)
        {
            var result = PalindromeNumber.Solve(number);
            Assert.False(result);
        }
    }
}