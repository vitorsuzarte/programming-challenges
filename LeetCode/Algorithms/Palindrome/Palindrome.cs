namespace LeetCode.Algorithms.Palindrome;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        var str = x.ToString();
        var strLength = str.Length - 1;

        for (var i = 0; i <= strLength; i++)
        {
            var oppositeChar = strLength - i;

            if (str[i] != str[oppositeChar])
                return false;

            if (i > strLength / 2)
                break;
        }

        return true;
    }

    public bool IsPalindrome2(int x)
    {
        var reversed = 0;
        var num = x;

        while (num >= 1)
        {
            reversed = reversed * 10 + num % 10;
            num = num / 10;
            
        }

        if (reversed == x)
            return true;

        return false;
    }
}

public static class Palindrome
{
    public static void Solution(int x)
    {
        var solution = new Solution();
        Console.WriteLine(solution.IsPalindrome2(x));
    }
}