namespace LeetCodeTest.Problems;

public class ValidParenthesesProblem
{
    public static bool Solve(string s)
    {
        var charsStack = new Stack<char>();

        for (var i = 0; i < s.Count(); i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                charsStack.Push(s[i]);
                continue;
            }

            if (s[i] == '}')
            {
                if (charsStack.Any() && charsStack.Pop() == '{')
                {
                    continue;
                }
                return false;
            }
            if (s[i] == ']')
            {
                if (charsStack.Any() && charsStack.Pop() == '[')
                {
                    continue;
                }
                return false;
            }
            if (s[i] == ')')
            {
                if (charsStack.Any() && charsStack.Pop() == '(')
                {
                    continue;
                }
                return false;
            }
        }

        return !charsStack.Any();
    }
}