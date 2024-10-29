public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for(int i=0; i<nums.Length; i++)
        {
            for(int j = i+1; j<nums.Length; j++)
            {
                int result = nums[i] + nums[j];
                if (result == target) return new int[] { i,j };
            }
        }
        return [1, 1];
    }

    public static void Main()
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"[{result[0]},{result[1]}]");
        nums = new int[] { 3, 2, 4 };
        target = 6;
        result = TwoSum(nums, target);
        Console.WriteLine($"[{result[0]},{result[1]}]");
        nums = new int[] { 3, 3 };
        target = 6;
        result = TwoSum(nums, target);
        Console.WriteLine($"[{result[0]},{result[1]}]");
    }
}