using LeetcodeProblems.Problems;

namespace LeetCodeTest.Problems;

public class PlusOneProblemTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]
    public void Solve_ShouldReturnCorrectArray(int[] nums, int[] expectedResult)
    {
        var result = PlusOneProblem.Solve(nums);
        Assert.Equal(expectedResult, result);
    }
}