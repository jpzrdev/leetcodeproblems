namespace LeetCodeTest.Problems;

public class RemoveDuplicatesFromSortedArrayProblem
{
    public static int Solve(int[] nums)
    {
        var k = 1;

        for (var i = 1; i < nums.Count(); i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }

    public static int SolveHashSet(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            hashSet.Add(num);
        }

        return hashSet.Count();
    }
}