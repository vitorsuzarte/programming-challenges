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

    public int[] TwoSum2(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dict.TryGetValue(complement, out var complementIndex))
            {
                return [i, complementIndex];
            }

            dict[nums[i]] = i;
        }

        return [];
    }
}

public static class TwoSum
{
    public static void Solution(int[] nums, int target)
    {
        var solution = new Solution();
        // var result = solution.TwoSum(nums, target);
        var result = solution.TwoSum2(nums, target);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}