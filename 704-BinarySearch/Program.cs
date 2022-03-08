// See https://aka.ms/new-console-template for more information
//Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
//Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 0));

int Search(int[] nums, int target)
{
    // First check whether the target is larger or smaller than the mid point of the array.
    var searchSubset = new Tuple<int, int>(0, nums.Length - 1);
    while (searchSubset.Item1 <= searchSubset.Item2)
    {
        var searchIndex = Math.Abs((searchSubset.Item1 + searchSubset.Item2) / 2);
        var searchValue = nums[searchIndex];
        {
            // Check if target is equal to searchValue.
            if (target == searchValue)
                return searchIndex;

            if (target > searchValue)
            {
                searchSubset = new Tuple<int, int>(searchIndex + 1, searchSubset.Item2);
            }
            else
            {
                searchSubset = new Tuple<int, int>(searchSubset.Item1, searchIndex - 1);
            }
        }
    }

    return -1;

}