namespace LeetCodeTest.Problems;

public class LongestCommonPrefixProblem
{
    public static string Solve(string[] strs)
    {
        var commonPrefix = strs[0];
        for (var i = 1; i < strs.Count(); i++)
        {
            var currentWord = strs[i];
            var newCommonPrefix = string.Empty;
            for (var j = 0; j < Math.Min(currentWord.Length, commonPrefix.Length); j++)
            {
                if (currentWord[j] == commonPrefix[j])
                {
                    newCommonPrefix += currentWord[j];
                }
            }

            if (newCommonPrefix == string.Empty)
                return newCommonPrefix;

            commonPrefix = newCommonPrefix;
        }

        return commonPrefix;
    }
}