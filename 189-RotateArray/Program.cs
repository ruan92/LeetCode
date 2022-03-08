// See https://aka.ms/new-console-template for more information
Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
Console.WriteLine("Exiting...");

void Rotate(int[] nums, int k)
{
    // Get the modulo
    k = k % nums.Length;

    var newArray = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        newArray[(i + k) % (nums.Length)] = nums[i];
    }

    Array.Copy(newArray, nums, newArray.Length);
}