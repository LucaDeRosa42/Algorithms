// Interpolation search (requires a sorted array, best with uniformly distributed values)
// Time Complexity:
// Best: O(1)
// Average: O(log log n)
// Worst: O(n)

public class InterpolationSearch
{
    public static int Search(int[] array, int target)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        int low = 0;
        int high = array.Length - 1;

        while (low <= high && target >= array[low] && target <= array[high])
        {
            if (array[high] == array[low])
                return array[low] == target ? low : -1;

            // estimate the position based on the value distribution
            long offset = ((long)target - array[low]) * (high - low) / ((long)array[high] - array[low]);
            int pos = low + (int)offset;

            if (array[pos] == target)
                return pos;

            if (array[pos] < target)
                low = pos + 1;
            else
                high = pos - 1;
        }

        return -1;
    }
}
