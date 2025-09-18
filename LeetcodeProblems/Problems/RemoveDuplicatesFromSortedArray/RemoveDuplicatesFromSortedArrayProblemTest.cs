namespace LeetCodeTest.Problems;

public class RemoveDuplicatesFromSortedArrayProblemTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 0, 0, 1, 1, 1, 2, 3, 3, 3, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 3 }, 3)]

    public void Solve_ShouldReturnCorrectLength(int[] nums, int expectedLength)
    {
        var result = RemoveDuplicatesFromSortedArrayProblem.Solve(nums);
        Assert.Equal(result, expectedLength);
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 0, 0, 1, 1, 1, 2, 3, 3, 3, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 3 }, 3)]

    public void SolveHashSet_ShouldReturnCorrectLength(int[] nums, int expectedLength)
    {
        var result = RemoveDuplicatesFromSortedArrayProblem.SolveHashSet(nums);
        Assert.Equal(result, expectedLength);
    }
}