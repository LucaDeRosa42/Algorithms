public class BinarySearch
{
    public static int Search(int[] array, int target)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        int left = 0;
        int right = array.Length - 1;

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