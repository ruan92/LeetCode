using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977_SquaresOfASortedArray
{
    public class Algorithm
    {
        public int[] SortedSquares(int[] nums)
        {
            var startPointer = 0;
            var endPointer = nums.Length - 1;

            var result = new int[nums.Length];
            var insertIndex = nums.Length -1;

            while(insertIndex >= 0)
            {
                var startSquare = (int) Math.Pow(nums[startPointer], 2);
                var endSquare = (int) Math.Pow(nums[endPointer], 2);

                if (startSquare > endSquare)
                {
                    result[insertIndex] = startSquare;
                    startPointer++;
                }
                else
                {
                    result[insertIndex] = endSquare;
                    endPointer--;
                }

                insertIndex--;
            }

            return result;
        }
    }
}
