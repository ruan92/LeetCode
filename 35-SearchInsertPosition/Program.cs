// See https://aka.ms/new-console-template for more information
Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 2));

int SearchInsert(int[] nums, int target)
{
    var left = 0;
    var right = nums.Length - 1;
    var pivot = 0;

    while (left <= right)
    {
        pivot = left + (right - left) / 2;
        var pivotValue = nums[pivot];

        if (pivotValue == target)
            return pivot;

        if (target > pivotValue)
        {
            left = pivot + 1;
        }
        else
        {
            right = pivot - 1;
        }
    }

    return left;
}