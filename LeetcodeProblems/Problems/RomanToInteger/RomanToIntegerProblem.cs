namespace LeetCodeTest.Problems
{
    public static class RomanToInteger
    {
        public static int Solve(string romanNumber)
        {
            var romanDictionary = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000},
            };

            var convertedInt = 0;

            for (var i = 0; i < romanNumber.Count(); i++)
            {
                var romanValue = romanDictionary[romanNumber[i].ToString()];
                if (i + 1 < romanNumber.Count() && romanValue < romanDictionary[romanNumber[i + 1].ToString()])
                {
                    convertedInt -= romanValue;
                }
                else
                {
                    convertedInt += romanValue;
                }
            }
            return convertedInt;
        }
    }
}