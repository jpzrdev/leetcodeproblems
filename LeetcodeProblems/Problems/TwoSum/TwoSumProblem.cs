namespace LeetCodeTest.Problems
{
    public static class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            for (var i = 0; i < nums.Count(); i++)
            {
                for (var j = i + 1; j < nums.Count(); j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }

            throw new Exception("No solution found");
        }
    }
}