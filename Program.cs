// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        int max = 0;
        int currentTotal = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (current == 1)
            {
                currentTotal++;
            }
            else
            {
                currentTotal = 0;
            }
            if (currentTotal > max)
                max = currentTotal;
        }
        return max;
    }
}