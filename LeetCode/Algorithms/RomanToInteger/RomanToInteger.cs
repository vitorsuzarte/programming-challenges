namespace LeetCode.Algorithms.RomanToInteger;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanDict = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        var result = 0;
        var i = 0;
        while (i < s.Length - 1)
        {
            var currentInt = romanDict[s[i]];
            var nextInt = romanDict[s[i + 1]];

            if (currentInt < nextInt)
            {
                result += nextInt - currentInt;
                i++;
            }
            else
            {
                result += currentInt;
            }

            i++;
        }

        if (i == s.Length - 1)
            result += romanDict[s[i]];
            
        return result;
    }
}

public class RomanToInteger
{
    public static void Solution(string s)
    {
        var sol = new Solution();
        Console.WriteLine(sol.RomanToInt(s));
    }
}