// Ternary search (requires a sorted array)
// Time Complexity:
// Best: O(1)
// Average: O(log₃ n)
// Worst: O(log₃ n)

public class TernarySearch
{
    public static int Search(int[] array, int target)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            // split the range into three parts
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;

            if (array[mid1] == target)
                return mid1;
            if (array[mid2] == target)
                return mid2;

            if (target < array[mid1])
                right = mid1 - 1;
            else if (target > array[mid2])
                left = mid2 + 1;
            else
            {
                left = mid1 + 1;
                right = mid2 - 1;
            }
        }

        return -1;
    }
}
