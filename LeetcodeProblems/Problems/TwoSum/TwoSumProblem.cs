namespace LeetCodeTest.Problems
{
    public static class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>
            {
                {target - nums[0], 0}
            };

            for (var i = 1; i < nums.Length; i++)
            {
                if (dictionary.TryGetValue(nums[i], out int value))
                {
                    return [value, i];
                }
                dictionary.Add(target - nums[i], i);
            }

            throw new Exception("No solution found");
        }
    }
}