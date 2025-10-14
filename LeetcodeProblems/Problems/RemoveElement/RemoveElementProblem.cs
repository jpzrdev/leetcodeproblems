namespace LeetCodeTest.Problems;

public class RemoveElementProblem
{
    public static int Solve(int[] nums, int val)
    {
        var k = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}