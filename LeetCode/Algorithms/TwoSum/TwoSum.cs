namespace LeetCode.Algorithms.TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            var complementIndex = Array.LastIndexOf(nums, complement);

            if (complementIndex == i || complementIndex == -1)
                continue;

            return [i, complementIndex];
        }

        return [];
    }
}

public static class TwoSum
{
    public static void Solution(int[] nums, int target)
    {
        var solution = new Solution();
        var result = solution.TwoSum(nums, target);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}