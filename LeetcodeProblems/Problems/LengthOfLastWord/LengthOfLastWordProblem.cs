namespace LeetCodeTest.Problems;

public class LengthOfLastWordProblem
{
    public static int Solve(string s)
    {
        var longestStringNumber = 0;
        var currentWordCount = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                currentWordCount = 0;
                continue;
            }
            currentWordCount++;

            if (currentWordCount > longestStringNumber)
            {
                longestStringNumber = currentWordCount;
            }
        }
        return longestStringNumber;
    }
}