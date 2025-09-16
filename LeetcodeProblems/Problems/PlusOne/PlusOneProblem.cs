namespace LeetcodeProblems.Problems;

public class PlusOneProblem
{
    public static int[] Solve(int[] nums)
    {
        var numsToString = "";

        foreach (var num in nums)
        {
            numsToString += num;
        }

        var numsPlusOneToString = (Convert.ToInt64(numsToString) + 1).ToString();

        var listInt = new List<int>();

        foreach (var charNum in numsPlusOneToString)
        {
            listInt.Add(charNum - '0');
        }

        return [.. listInt];
    }
}