namespace LeetCodeTest.Problems
{
    public class TwoSumProblemTest
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 5, 9, 12 }, 14, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 5, 9, 12 }, 13, new int[] { 0, 3 })]
        public void Solve_ShouldReturnCorrectSolution(int[] nums, int target, int[] expectedResult)
        {
            var result = TwoSum.Solve(nums, target);
            Assert.Equal(expectedResult, result);
        }

        // [Fact]
        // public void Solve_ShouldReturnExceptionWhenNotSolutionIsFound()
        // {
        //     var result = TwoSum.Solve([1, 2, 3], 7);
        //     Assert.Empty(result);
        // }
    }
}