using System;

namespace DSA.Lab01
{
    public static class SortAlgorithms
    {
        public static void InsertionSort(int[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            // TODO: Sort the array in ascending order using insertion sort.
            //
            // Think of values[0..i-1] as the already-sorted part.
            // For each next value:
            // 1. Store the value you want to insert.
            // 2. Shift larger values one position to the right.
            // 3. Put the stored value into the gap.

            for (int i = 1; i < values.Length; i++)
            {
                // Temporary int, the one we're currently sorting into it's right place
                int tempInt = values[i];

                // Will keep track of the element to the left of i
                int j = i - 1;

                // While loop will continue to loop to compare to the element left of i while j is greater or equal to 0
                // and while values[j] is greater than tempInt

                while (j >= 0 && values[j] > tempInt)
                {
                    values[j + 1] = values[j];
                    j--;
                }
                values[j + 1] = tempInt;

            }

        }
    }
}
