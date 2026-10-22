using System;

namespace DSA.Lab01
{
    public static class SearchAlgorithms
    {
        public static int LinearSearch(int[] values, int target)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            
            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] sortedValues, int target)
        {
            if (sortedValues == null)
            {
                throw new ArgumentNullException(nameof(sortedValues));
            }

            int highIndex = sortedValues.Length - 1;
            int mid;
            int lowIndex = 0;

            while (lowIndex <= highIndex)
            {
                mid = (lowIndex + highIndex) /2;

                // If target is exactly the mid-point of the array, return with the mid-point as the result
                if (target == sortedValues[mid])
                {
                    return mid;
                }
                
                else if (target < sortedValues[mid])
                {
                    highIndex = mid - 1;
                }

                else
                {
                    lowIndex = mid + 1;
                }
            }


            // TODO: Implement binary search.
            // The input to this method is guaranteed to be sorted in ascending order.
            //
            // Suggested plan:
            // 1. Keep track of a low and high index.
            // 2. Inspect the middle value.
            // 3. Return the index if it matches.
            // 4. Otherwise discard either the lower or upper half.
            // 5. Repeat while there is still a valid search range.
            return -1;
        }
    }
}
