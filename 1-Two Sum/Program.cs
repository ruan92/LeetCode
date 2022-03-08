// See https://aka.ms/new-console-template for more information
TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine("Exiting...");

int[] TwoSum(int[] nums, int target)
{
    var map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (map.TryGetValue(target - nums[i], out var value))
        {
            return new int[] { value, i };
        }
        else
        {
            map.TryAdd(nums[i], i);
        }
    }

    return Array.Empty<int>();
}