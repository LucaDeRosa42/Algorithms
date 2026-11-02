// Exponential search (requires a sorted array)
// Time Complexity:
// Best: O(1)
// Average: O(log i), where i is the target position
// Worst: O(log n)

public class ExponentialSearch
{
    public static int Search(int[] array, int target)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        int n = array.Length;
        if (n == 0)
            return -1;

        if (array[0] == target)
            return 0;

        // double the bound until it passes the target
        int bound = 1;
        while (bound < n && array[bound] < target)
            bound *= 2;

        // binary search inside [bound / 2, min(bound, n - 1)]
        int left = bound / 2;
        int right = Math.Min(bound, n - 1);

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}
