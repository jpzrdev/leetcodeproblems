namespace LeetCodeTest.Problems;

public class FindIndexOfFirstOccurrenceInAStringProblem
{
    public static int Solve(string haystack, string needle)
    {
        var n = haystack.Length;
        var m = needle.Length;

        for (int i = 0; i <= n - m; i++)
        {
            int j = 0;
            while (j < m && haystack[i + j] == needle[j])
            {
                j++;
            }

            if (j == m)
                return i;
        }

        return -1;
    }
}