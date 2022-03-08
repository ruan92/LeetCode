// See https://aka.ms/new-console-template for more information
//Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
Merge(new int[] { 1, 2, 4, 5, 6, 0 }, 5, new int[] { 3 }, 1);
Console.WriteLine("Exiting...");

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    var insertIndex = 0;
    var seekIndex = 0;
    var nums1Count = m;

    //for (int i = 0; i < n; i++)
    //{
    while(seekIndex < n && insertIndex < nums1.Length)
    { 
        if (nums1[insertIndex] >= nums2[seekIndex])
        {
            MoveToRight(nums1, insertIndex, nums1Count);
            nums1[insertIndex] = nums2[seekIndex++];
            nums1Count++;
        }
        else if (insertIndex >= nums1Count)
        {
            nums1[insertIndex] = nums2[seekIndex++];
        }

        insertIndex++;
    }
}

void MoveToRight(int[] nums, int i, int nums1Count)
{
    for (var j = nums1Count - 1; j >= i; j--)
    {
        nums[j + 1] = nums[j];
    }
}

    //var i = 0;
    //var j = 0;
    //var insertIndex = m;

    //while (i < m && j < n)
    //{
    //    if (nums1[i] <= nums2[j])
    //    {
    //        nums1[insertIndex++] = nums1[i++];
    //    }
    //    else if (nums1[1] > nums2[j])
    //    {
    //        nums1[insertIndex++] = nums2[j++];
    //    }
    //}
//}