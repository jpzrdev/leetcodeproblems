namespace LeetCodeTest.Problems
{
    public static class PalindromeNumber
    {
        public static bool Solve(int number)
        {
            var numberStr = number.ToString();

            var start = 0;
            var end = numberStr.Count() - 1;

            while (start < end)
            {
                if (numberStr[start] == numberStr[end])
                {
                    start++;
                    end--;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}