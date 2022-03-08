// See https://aka.ms/new-console-template for more information
Intersect(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
Console.WriteLine("Exiting...");

int[] Intersect(int[] nums1, int[] nums2)
{
    var map = new Dictionary<int, int>();

    // Assign small and large arrays.
    int[] largeArray;
    int[] smallArray;

    if (nums1.Length > nums2.Length)
    {
        largeArray = nums1;
        smallArray = nums2;
    }
    else
    {
        largeArray = nums2;
        smallArray = nums1;
    }

    var result = new List<int>();

    // Create index from small array.
    for (int i = 0; i < smallArray.Length; i++)
    {
        if (!map.TryAdd(smallArray[i], 1))
        {
            var value = map[smallArray[i]];
            map.Remove(smallArray[i]);
            map.Add(smallArray[i], ++value);
        }
    }

    for (int i = 0; i < largeArray.Length; i++)
    {
        if (map.TryGetValue(largeArray[i], out var value))
        {
            result.Add(largeArray[i]);

            map.Remove(largeArray[i]);
            if (value - 1 > 0)
                map.Add(largeArray[i], --value);
        }

        if (map.Count == 0)
            break;
    }

    return result.ToArray();
}