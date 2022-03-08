// See https://aka.ms/new-console-template for more information
int _maxSum = 0;
bool isMaxSumInit = false;
Console.WriteLine(MaxSubArray(new int[] { 5, 10, -9, -10, 14, 10 }));
//Console.WriteLine(MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));

int MaxSubArray(int[] nums)
{
    int sum = 0;
    int max = nums[0];
    int n = nums.Length;

    for (int i = 0; i < n; i++)
    {
        sum += nums[i];
        if (sum > max) max = sum;
        if (sum < 0) sum = 0;
    }
    return max;

}

//int MaxSubArray(int[] nums)
//{
//    var hashTable = new Dictionary<KeyValuePair<int, int>, int>();

//    for (int i = 0; i < nums.Length; i++)
//    {
//        // Create new sublist.
//        hashTable.TryAdd(new KeyValuePair<int, int> ( i, i ), nums[i]);

//        SetMaxSum(nums[i]);

//        // Add to existing sublists
//        for (int j = 0; j < i; j++)
//        {
//            var hashTableSum = hashTable.GetValueOrDefault(new KeyValuePair<int, int> ( j, i - 1 ));
//            var sum = hashTableSum + nums[i];
//            hashTable.TryAdd(new KeyValuePair<int, int>(j, i), sum);
//            SetMaxSum(sum);
//        } 
//    }

//    return _maxSum;
//}

//void SetMaxSum(int sum)
//{
//    if (!isMaxSumInit)
//    {
//        _maxSum = sum;
//        isMaxSumInit = true;
//        return;
//    }

//    if (sum > _maxSum)
//        _maxSum = sum;
//}