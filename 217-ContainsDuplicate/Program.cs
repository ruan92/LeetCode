// See https://aka.ms/new-console-template for more information
Console.WriteLine(ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));

bool ContainsDuplicate(int[] nums)
{
    // Create a hash table to use as index to see if duplicate exists.
    var hashTable = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (!hashTable.TryAdd(nums[i], nums[i]))
            return true;
    }

    return false;
}